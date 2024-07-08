using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ImageProcessing;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace _3grade_Project
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private FramGrabber _FrameGrabber = new FramGrabber();
        private CogGraphicInteractiveCollection recCollection = new CogGraphicInteractiveCollection();
        private ICogImage grabImg;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_FrameGrabber.IsConnect())
            {
                _FrameGrabber.Camera_Connect();
                MessageBox.Show("카메라 연결 성공");
            }
            else
            {
                MessageBox.Show("카메라 연결 실패");
            }

            InitializeCogDisplay();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://school.gyo6.net/gbsw/main.do?sysId=gbsw";
            System.Diagnostics.Process.Start(url);
        }

        private void Header_Panel_SizeChanged(object sender, EventArgs e)
        {
            Design.Header((Control)sender);
        }

        private void Trigger_Click(object sender, EventArgs e)
        {
            if (_FrameGrabber.IsConnect())
            {
                grabImg = _FrameGrabber.ImgGrade();

                if (grabImg != null)
                {
                    cogDisplay1.Image = grabImg;
                    cogDisplay1.Fit(true);
                    MessageBox.Show("이미지 트리거 성공. ROI를 설정하세요.");

                    // 기존 ROI 제거
                    recCollection.Clear();
                    cogDisplay1.InteractiveGraphics.Clear();

                    // ROI 설정 가능
                    CogRectangle roi = new CogRectangle
                    {
                        Interactive = true,
                        GraphicDOFEnable = CogRectangleDOFConstants.All,
                        X = 100,
                        Y = 150,
                        Width = 750,
                        Height = 750,
                        Color = CogColorConstants.White
                    };

                    recCollection.Add(roi);
                    cogDisplay1.InteractiveGraphics.AddList(recCollection, null, false);
                }
                else
                {
                    MessageBox.Show("이미지 트리거 실패");
                }
            }
            else
            {
                MessageBox.Show("카메라가 연결되지 않았습니다.");
            }
        }


        private void InitializeCogDisplay()
        {
            cogDisplay1.ColorMapLowerRoiLimit = 0D;
            cogDisplay1.ColorMapPredefined = CogDisplayColorMapPredefinedConstants.None;
            cogDisplay1.ColorMapUpperClipColor = Color.Black;
            cogDisplay1.ColorMapUpperRoiLimit = 1D;
            cogDisplay1.DoubleTapZoomCycleLength = 2;
            cogDisplay1.DoubleTapZoomSensitivity = 2.5D;
            cogDisplay1.Location = new Point(13, 12);
            cogDisplay1.Size = new Size(400, 497);
        }

        private ICogImage CropImage(ICogImage originalImage, CogRectangle roi)
        {
            try
            {
                bool srcClipped, dstClipped;
                ICogRegion dstRegion;

                CogCopyRegion copyRegion = new CogCopyRegion();
                ICogImage croppedImage = copyRegion.Execute(originalImage, roi, null, out srcClipped, out dstClipped, out dstRegion);

                return croppedImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"이미지 자르기 중 오류 발생: {ex.Message}");
                return null;
            }
        }

        private void CropImageButton_Click_1(object sender, EventArgs e)
        {
            if (grabImg != null && recCollection.Count > 0)
            {
                CogRectangle roi = (CogRectangle)recCollection[0];
                ICogImage croppedImage = CropImage(grabImg, roi);

                if (croppedImage != null)
                {
                    cogDisplay2.Image = croppedImage;
                    cogDisplay2.Fit(true);
                    MessageBox.Show("이미지 자르기 성공");

                    
                }
                else
                {
                    MessageBox.Show("이미지 자르기 실패");
                }
            }
            else
            {
                MessageBox.Show("이미지를 먼저 트리거 하고 ROI를 설정하세요.");
            }
        }

        private void examine_Click(object sender, EventArgs e)
        {
            CogRectangle roi = (CogRectangle)recCollection[0];
            ICogImage croppedImage = CropImage(grabImg, roi);
            cogDisplay2.Image = croppedImage;
            
            // 잘린 이미지를 파일로 저장
            SaveCroppedImageToFile(croppedImage, "Z:\\Capture_data\\image.jpg");

            //10초동안 슬립
            Thread.Sleep(8000);

            // 첫 번째 파일 경로에서 이미지 로드
            string firstFilePath = "Z:\\Predict_result\\heatmap.png";
            ICogImage firstLoadedImage = LoadImageFromFile(firstFilePath);
            cogDisplay3.Image = firstLoadedImage;

            // 두 번째 파일 경로에서 이미지 로드
            string secondFilePath = "Z:\\Predict_result\\histogram.png";
            ICogImage secondLoadedImage = LoadImageFromFile(secondFilePath);
            cogDisplay4.Image = secondLoadedImage;

            // 세 번째 파일 경로에서 텍스트 파일 로드
            string thirdFilePath = "Z:\\Predict_result\\result.txt";
            string textContent = LoadTextFromFile(thirdFilePath);
            lblResult1.Text = textContent;


            //경로의 모든 파일 삭제
            string directoryPath = "Z:\\Predict_result";
            DeleteAllFilesInDirectory(directoryPath);
        }

        // 잘린 이미지를 파일로 저장하는 메서드
        private void SaveCroppedImageToFile(ICogImage image, string filePath)
        {
            try
            {
                if (image == null)
                {
                    throw new ArgumentNullException(nameof(image));
                }

                CogImageFileBMP imageFile = new CogImageFileBMP();
                imageFile.Open(filePath, CogImageFileModeConstants.Write);
                imageFile.Append(image);
                imageFile.Close();

                MessageBox.Show("이미지가 성공적으로 저장되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지 저장 중 오류 발생: " + ex.Message);
            }
        }

        // 파일에서 이미지를 로드하는 메서드
        private ICogImage LoadImageFromFile(string filePath)
        {
            try
            {
                CogImageFile imageFile = new CogImageFile();
                imageFile.Open(filePath, CogImageFileModeConstants.Read);
                ICogImage image = imageFile[0];
                imageFile.Close();
                return image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지를 로드하는 중 오류 발생: " + ex.Message);
                return null;
            }
        }
        //txt 읽어오기
        private string LoadTextFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath, System.Text.Encoding.UTF8);
                  
                }
                else
                {
                    MessageBox.Show("텍스트 파일이 존재하지 않습니다.");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("텍스트 파일을 읽는 중 오류 발생: " + ex.Message);
                return string.Empty;
            }
        }


        // 디렉토리의 모든 파일을 삭제하는 메서드
        private void DeleteAllFilesInDirectory(string directoryPath)
        {
            try
            {
                if (Directory.Exists(directoryPath))
                {
                    string[] files = Directory.GetFiles(directoryPath);
                    foreach (string file in files)
                    {
                        File.Delete(file);
                    }
                    MessageBox.Show("경로의 모든 파일이 성공적으로 삭제되었습니다.");
                }
                else
                {
                    MessageBox.Show("지정된 경로가 존재하지 않습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("파일 삭제 중 오류 발생: " + ex.Message);
            }
        }



    }

    public class FramGrabber
    {
        public ICogFrameGrabber _Grabber;
        public ICogAcqFifo _AcqFifo;

        public bool IsConnect()
        {
            try
            {
                CogFrameGrabbers cogFrameGrabbers = new CogFrameGrabbers();
                if (cogFrameGrabbers.Count > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("카메라가 연결되지 않았습니다.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"카메라 연결 상태 확인 중 오류 발생: {ex.Message}");
                return false;
            }
        }

        public void Camera_Connect()
        {
            try
            {
                CogFrameGrabbers cogFrameGrabbers = new CogFrameGrabbers();
                if (cogFrameGrabbers.Count > 0)
                {
                    _Grabber = cogFrameGrabbers[0];
                    _AcqFifo = _Grabber.CreateAcqFifo(_Grabber.AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                    _AcqFifo.OwnedExposureParams.Exposure = 100;
                }
                else
                {
                    MessageBox.Show("카메라가 연결되지 않았습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"카메라 연결 중 오류 발생: {ex.Message}");
            }
        }

        public ICogImage ImgGrade()
        {
            try
            {
                int Trigger;
                _AcqFifo.OwnedExposureParams.Exposure = 100;
                return _AcqFifo.Acquire(out Trigger);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
