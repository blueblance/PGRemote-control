using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using PGRemoteRPC;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Web;
using Excel = Microsoft.Office.Interop.Excel;




namespace PGRemote_control
{


    public partial class Form1 : Form
    {

        private Capture cap = null;
        PGRemoteRPCClient client = new PGRemoteRPCClient();
        public string errMsg = "";
        public string statusMsg = "";
        public string AppDir = System.Windows.Forms.Application.StartupPath + "\\";
        public static bool m_usingP338 = true;
        public bool webcamen = true;
        public bool stoploop = false;
        delegate void SetTextCallback(string text, string text2);
        public const byte RESETPIN_MSG = 0x04;
        public const int SETUP_SIZE = 0x07;
        public static byte[] AllocPayload(int len)
        {
            byte[] payload = new byte[len];
            for (int i = 0; i < len; i++)
            {
                payload[i] = (byte)(i & 0xff);
            }
            return (payload);
        }

        public static int PQ(string cmdName, int rc)
        {
            if (rc < 0)
                Console.WriteLine(string.Format("Error {0} occurred in RPC query: {0}", rc, cmdName));
            else
                Console.WriteLine(string.Format("{0} returned {1}", cmdName, rc));
            return (rc);
        }

        // notify user if return code negative
        // (set breakpoint on WriteLine call to debug which command had error)
        public static int PE(int rc)
        {
            if (rc < 0)
                Console.WriteLine(string.Format("Error {0} occurred in RPC command!", rc));
            return (rc);
        }
        public Form1()
        {
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
            globalpar.bwcount = 0;
            checkedListBox1.SetItemChecked(0, true);
            globalpar.pixelformat = 24;
            //cap = new Capture(0);
            //Application.Idle += new EventHandler(Application_Idle);
            if (checkBox_webcam.Checked == true)

                cap = new Capture(0);

            else
            {

            }





        }

        void Application_Idle(object sender, EventArgs e)
        {

            //Image<Bgr, Byte> camimage = cap.QueryFrame();
            //pictureBox1.Image = camimage.Bitmap;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rc = client.Connect("", 2799);
            if (rc < 0)
            {
                textBox1.Text = "fail";
            }
            else
            {
                textBox1.Text = "ok";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void btn_pgabort_Click(object sender, EventArgs e)
        {


            PE(client.PGRemoteCmd(RPCCmds.PG_ABORT, ref errMsg, ref statusMsg));
        }

        private void btn_bta_Click(object sender, EventArgs e)
        {
            textbox_statusmsg.Text = "";
            byte[] DUTResp = new byte[0];
            PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
            PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
            //foreach (byte element in DUTResp)
            // {
            string hex = BitConverter.ToString(DUTResp);
            textbox_statusmsg.Text = textbox_statusmsg.Text + hex;
            //}







        }

        private void btn_lp_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_hs.Checked == true)
            {
                PE(client.PGRemoteCmd(RPCCmds.SET_DT_MODE, RPCDefs.DT_HS, ref errMsg, ref statusMsg));
            }
            else
            {
                PE(client.PGRemoteCmd(RPCCmds.SET_DT_MODE, RPCDefs.DT_LP, ref errMsg, ref statusMsg));
            }

        }

        private void btn_hs_CheckedChanged(object sender, EventArgs e)
        {

            if (btn_hs.Checked == true)
            {
                PE(client.PGRemoteCmd(RPCCmds.SET_DT_MODE, RPCDefs.DT_HS, ref errMsg, ref statusMsg));
            }
            else
            {
                PE(client.PGRemoteCmd(RPCCmds.SET_DT_MODE, RPCDefs.DT_LP, ref errMsg, ref statusMsg));
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_4lane_CheckedChanged(object sender, EventArgs e)
        {
            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
            if (btn_4lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 4, ref errMsg, ref statusMsg));
            else if (btn_3lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 3, ref errMsg, ref statusMsg));
            else if (btn_2lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 2, ref errMsg, ref statusMsg));
            else
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 1, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));

        }

        private void btn_3lane_CheckedChanged(object sender, EventArgs e)
        {
            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
            if (btn_4lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 4, ref errMsg, ref statusMsg));
            else if (btn_3lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 3, ref errMsg, ref statusMsg));
            else if (btn_2lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 2, ref errMsg, ref statusMsg));
            else
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 1, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
        }

        private void btn_2lane_CheckedChanged(object sender, EventArgs e)
        {
            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
            if (btn_4lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 4, ref errMsg, ref statusMsg));
            else if (btn_3lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 3, ref errMsg, ref statusMsg));
            else if (btn_2lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 2, ref errMsg, ref statusMsg));
            else
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 1, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
        }
        private void btn_1lane_CheckedChanged(object sender, EventArgs e)
        {
            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
            if (btn_4lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 4, ref errMsg, ref statusMsg));
            else if (btn_3lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 3, ref errMsg, ref statusMsg));
            else if (btn_2lane.Checked == true)
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 2, ref errMsg, ref statusMsg));
            else
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 1, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
        }

        private void btn_openbmp_Click(object sender, EventArgs e)
        {
            openvideopic.ShowDialog();
            //openvideopic.Filter = "BMP(*.bmp)|*.bmp";
            textbox_videopicpath.Text = openvideopic.FileName;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = openvideopic.FileName;
            //textbox_fortest.Text = openvideopic.FileName.Substring(0, textboxrpcsave.Text.LastIndexOf("\\"))
            Image<Bgr, Byte> img1 = new Image<Bgr, byte>(openvideopic.FileName);
            globalpar.imagehigh = img1.Height;
            globalpar.imagewidth = img1.Width;
            PE(client.PGRemoteCmd(RPCCmds.SET_WM_PARTITION_LENGTH, globalpar.imagewidth * 30, ref errMsg, ref statusMsg));

        }

        private void btn_senvideopic_Click(object sender, EventArgs e)
        {
            PE(client.MIPICmd(RPCDefs.PACKED_PIXEL_STREAM_888, 0, false, RPCDefs.DT_HS, 0, 1, 0, 0, AppDir + openvideopic.FileName, null, ref errMsg, ref statusMsg));
        }

        private void btn_fortest_Click(object sender, EventArgs e)
        {
            /*
            string autoseq;
            StreamReader sr = new StreamReader(openfiletestseq.FileName);
            //while (!sr.EndOfStream)
            autoseq = sr.ReadLine();
            char[] delimiterChars = { ',' };
            string[] words = autoseq.Split(delimiterChars);
            if (words[0] == "WRITE")
            {
                int wordcount = (words.Length) - 1;
                byte[] data = new byte[wordcount];
                for (int i =1 ; i<= wordcount ; i++)
                {
                    data[i-1] = words[i]
                }

            }
            
            byte[] DUTResp = new byte[0];
            byte[] data = new byte[4];
            data[0] = 0x55;
            data[1] = 0xAA;
            data[2] = 0x55;
            data[3] = 0xAA;
            PE(client.MIPICmd(RPCDefs.CUSTOM_COMMAND, 0, false, RPCDefs.DT_HS, 0, 0x39, 0, 0, "", data, ref errMsg, ref statusMsg));
            
            */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            byte[] data = new byte[1];
            data[0] = 0x0a;
            PE(client.MIPICmd(RPCDefs.CUSTOM_COMMAND, 0, true, RPCDefs.DT_HS, 0, 0x06, 0, 0, "", data, ref errMsg, ref statusMsg));
        }


        private void btn_longwrite_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[100];
            for (int inx = 0; inx < 100; inx++)
            {
                data[inx] = (byte)inx;
            }
            PE(client.MIPICmd(RPCDefs.CUSTOM_COMMAND, 0, false, RPCDefs.DT_HS, 0, 0xfd, 0, 0, "", data, ref errMsg, ref statusMsg));
            textbox_fortest.Text = statusMsg;

        }

        private void textbox_par_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_opencam_Click(object sender, EventArgs e)
        {
            if (this.backgroundWorkerwebcam.IsBusy != true)
            {
                this.backgroundWorkerwebcam.WorkerReportsProgress = true;
                this.backgroundWorkerwebcam.RunWorkerAsync();

            }
            else
                textbox_fortest.Text = "buttonn fail";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textbox_fortest2.Text = getbta();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            opendutpath.ShowDialog();
            textboxrpcsave.Text = opendutpath.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int hsfreq;
            int lpfreq;
            hsfreq = Convert.ToInt32(textbox_hsfreq.Text);
            lpfreq = Convert.ToInt32(textbox_lpfreq.Text);
            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, (float)hsfreq * 1000000, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_LP_FREQ, (float)lpfreq * 1000000, ref errMsg, ref statusMsg));



            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
        }

        private void btn_sendsmrps_Click(object sender, EventArgs e)
        {

            PE(client.MIPICmd(RPCDefs.SET_MAX_RETURN_PKT_SIZE, 0, false, RPCDefs.DT_HS, 0, 0x1234, 0, 0, "", null, ref errMsg, ref statusMsg));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_savecam_Click(object sender, EventArgs e)
        {
            string strFilePath = opendutpath.FileName.ToString();
            string FilePath = @strFilePath.Substring(0, strFilePath.LastIndexOf("\\"));
            pictureBox1.Image.Save(FilePath + "abc.jpg" , System.Drawing.Imaging.ImageFormat.Jpeg);

        }

        private void btn_runautotest_Click(object sender, EventArgs e)
        {
            int hsa, hbp, hfp, hact, vsa, vbp, vfp, vact, fr, lanecnt, hsbitrate, targetbitrate;
            float bitrate;
            stoploop = false;
            byte[] DUTResp = new byte[0];
            if (btn_4lane.Checked == true)
                lanecnt = 4;
            else if (btn_3lane.Checked == true)
                lanecnt = 3;
            else if (btn_2lane.Checked == true)
                lanecnt = 2;
            else
                lanecnt = 1;
            hsa = Convert.ToInt32(textboxhsa.Text);
            hbp = Convert.ToInt32(textboxhbp.Text);
            hfp = Convert.ToInt32(textboxhfp.Text);
            vsa = Convert.ToInt32(textboxvsa.Text);
            vbp = Convert.ToInt32(textboxvbp.Text);
            vfp = Convert.ToInt32(textboxvfp.Text);
            hact = Convert.ToInt32(textboxhact.Text);
            vact = Convert.ToInt32(textboxvact.Text);
            fr = Convert.ToInt32(textboxfr.Text);
            targetbitrate = (Convert.ToInt32(textboxtagetbitrate.Text) / 2);
            hsbitrate = Convert.ToInt32(textbox_hsfreq.Text);
            bitrate = ((hsa + hbp + hfp + hact) * (vsa + vbp + vfp + vact) * globalpar.pixelformat / lanecnt * fr / 1000000 / 2 + 1);
            textbox_hsfreq.Text = bitrate.ToString();
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC, hsa, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH, hbp, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH, hfp, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HACTIVE, hact, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VSYNC, vsa, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VBPORCH, vbp, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VFPORCH, vfp, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VACTIVE, vact, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_FRAME_RATE, fr, ref errMsg, ref statusMsg));
            /*
            while (bitrate < targetbitrate || stoploop == false)
            {
                if (bitrate < targetbitrate)
                {
                    hsa = hsa + 20;
                    bitrate = ((hsa + hbp + hfp + hact) * (vsa + vbp + vfp + vact) * 24 / lanecnt * fr / 1000000 / 2 + 1);
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC, hsa, ref errMsg, ref statusMsg));
                    textboxhsa.Text = hsa.ToString();
                    textbox_hsfreq.Text = bitrate.ToString();
                    Application.DoEvents();
                    button2_Click(sender, e);
                    if (bitrate < targetbitrate)
                    {
                        hbp = hbp + 20;
                        bitrate = ((hsa + hbp + hfp + hact) * (vsa + vbp + vfp + vact) * 24 / lanecnt * fr / 1000000 / 2 + 1);
                        PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH, hbp, ref errMsg, ref statusMsg));
                        textboxhbp.Text = hbp.ToString();
                        textbox_hsfreq.Text = bitrate.ToString();
                        Application.DoEvents();
                        button2_Click(sender, e);
                        if (bitrate < targetbitrate)
                        {
                            hfp = hfp + 20;
                            bitrate = ((hsa + hbp + hfp + hact) * (vsa + vbp + vfp + vact) * 24 / lanecnt * fr / 1000000 / 2 + 1);
                            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH, hfp, ref errMsg, ref statusMsg));
                            textboxhfp.Text = hfp.ToString();
                            textbox_hsfreq.Text = bitrate.ToString();
                            Application.DoEvents();
                            button2_Click(sender, e);

                        }

                    }

                }



            }
            */

        }

        private void btn_stoploop_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.WorkerReportsProgress = false;
            this.backgroundWorker1.CancelAsync(); //中斷背景程式
            this.backgroundWorker1.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UInt32 DevNum = 0;
            UInt32 devicenumber = 0;
            StringBuilder DevStr = new StringBuilder(SLUSBXpressDLL.SI_MAX_DEVICE_STRLEN);
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_GetNumDevices(ref DevNum);
            IntPtr hUSBDevice2 = this.Handle;
            byte[] buffer = new byte[6];

            Int32 IOBufSize = 12;
            Byte[] IOBuf = new Byte[IOBufSize];
            uint BytesSucceed = 0;





            if (SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS)
            {
                SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_GetProductString(devicenumber, DevStr, SLUSBXpressDLL.SI_RETURN_SERIAL_NUMBER);
                if (SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS)
                {
                    SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_SetTimeouts(10000, 10000);
                    //SLUSBXpressDLL.SI_Close(SLUSBXpressDLL.hUSBDevice);

                    SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Open(0, ref hUSBDevice2);
                    if (SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS)
                    {
                        buffer[0] = RESETPIN_MSG;
                        buffer[5] = 1;
                        SLUSBXpressDLL.Status = SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Write(hUSBDevice2, buffer, SETUP_SIZE, ref BytesSucceed, 0);
                        //if(SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS)
                        if ((BytesSucceed != SETUP_SIZE) || (SLUSBXpressDLL.Status != SLUSBXpressDLL.SI_SUCCESS))
                        {
                            MessageBox.Show("write fail");
                            Application.Exit();
                        }
                        else
                        {
                            buffer[0] = RESETPIN_MSG;
                            buffer[5] = 0;
                            SLUSBXpressDLL.Status = SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Write(hUSBDevice2, buffer, SETUP_SIZE, ref BytesSucceed, 0);
                            if ((BytesSucceed != SETUP_SIZE) || (SLUSBXpressDLL.Status != SLUSBXpressDLL.SI_SUCCESS))
                            {
                                MessageBox.Show("write fail");
                                Application.Exit();
                            }
                            else
                            {
                                buffer[0] = RESETPIN_MSG;
                                buffer[5] = 1;
                                SLUSBXpressDLL.Status = SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Write(hUSBDevice2, buffer, SETUP_SIZE, ref BytesSucceed, 0);
                                if ((BytesSucceed != SETUP_SIZE) || (SLUSBXpressDLL.Status != SLUSBXpressDLL.SI_SUCCESS))
                                {
                                    MessageBox.Show("write fail");
                                    Application.Exit();
                                }
                                else
                                {
                                    SLUSBXpressDLL.SI_Close(hUSBDevice2);
                                }

                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Fail");
                        return;
                    }

                }
                //status = SI_GetProductString(DeviceNumber, devStr, SI_RETURN_SERIAL_NUMBER);

            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //StreamWriter sw = new StreamWriter(@opendutpath.FileName, true);
            globalpar.testnum = 0;
            byte[] DUTResp = new byte[0];
            int inihsa = globalpar.hsa;
            int inihbp = globalpar.hbp;
            int inihfp = globalpar.hfp;

            do
            {
                if (backgroundWorker1.CancellationPending == true)
                {

                    e.Cancel = true;
                    break;


                }
                else
                {
                    globalpar.bitrate = ((globalpar.hsa + globalpar.hbp + globalpar.hfp + globalpar.hact) * (globalpar.vsa + globalpar.vbp + globalpar.vfp + globalpar.vact) * globalpar.pixelformat / globalpar.lanecnt * globalpar.fr / 1000000 / 2 + 1);
                    PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, ((float)globalpar.bitrate + 1) * 1000000, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_LP_FREQ, (float)18e+6, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH, globalpar.hfp, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH, globalpar.hbp, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC, globalpar.hsa, ref errMsg, ref statusMsg));

                    System.Threading.Thread.Sleep(1000);



                    if (globalpar.pixelformat == 24)
                    {
                        PE(client.MIPICmd(RPCDefs.PACKED_PIXEL_STREAM_888, 0, false, RPCDefs.DT_HS, 0, 1, 0, 0, textbox_videopicpath.Text, null, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.pixelformat == 18)
                    {
                        PE(client.MIPICmd(RPCDefs.PACKED_PIXEL_STREAM_666, 0, false, RPCDefs.DT_HS, 0, 1, 0, 0, textbox_videopicpath.Text, null, ref errMsg, ref statusMsg));
                    }
                    else
                    {
                        PE(client.MIPICmd(RPCDefs.PACKED_PIXEL_STREAM_565, 0, false, RPCDefs.DT_HS, 0, 1, 0, 0, textbox_videopicpath.Text, null, ref errMsg, ref statusMsg));
                    }
                    
                    PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
                    System.Threading.Thread.Sleep(globalpar.waittime);
                    PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SAVE_DUT_RESPONSE, textboxrpcsave.Text, 100, globalpar.pixelformat + "bit" + globalpar.videotype + (globalpar.bitrate) * 2 + " Mbps" + " " + globalpar.hsa + " " + globalpar.hbp + " " + globalpar.hfp + measfluke(), 0, ref errMsg, ref statusMsg));
                    backgroundWorker1.ReportProgress(0);

                    if (checkBox_webcam.Checked == true)
                    {
                        cap = new Capture(0);
                        Image<Bgr, Byte> camimage = cap.QueryFrame();
                        //because we are using an autosize picturebox we need to do a thread safe update
                        DisplayImage(camimage.ToBitmap());
                        cap.Dispose();
                        string savepath = Path.GetDirectoryName(opendutpath.FileName);
                        pictureBox1.Image.Save(@savepath +"\\" + globalpar.pixelformat + "bit" + globalpar.videotype + (Convert.ToInt32(textbox_hsfreq.Text) * 2).ToString() + "Mbps.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    }

                    else
                    {

                    }

                    PE(client.PGRemoteCmd(RPCCmds.PG_ABORT, ref errMsg, ref statusMsg));
                    switch (globalpar.testnum)
                    {
                        case 0:
                            globalpar.hsa = globalpar.hsa + 20;
                            globalpar.testnum = 1;
                            break;
                        case 1:
                            globalpar.hbp = globalpar.hbp + 20;
                            globalpar.testnum = 2;
                            break;
                        case 2:
                            globalpar.hfp = globalpar.hfp + 20;
                            globalpar.testnum = 0;
                            break;

                    }
                    /*
                    globalpar.bitrate = ((globalpar.hsa + globalpar.hbp + globalpar.hfp + globalpar.hact) * (globalpar.vsa + globalpar.vbp + globalpar.vfp + globalpar.vact) * globalpar.pixelformat / globalpar.lanecnt * globalpar.fr / 1000000 / 2 + 1);
                    PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, ((float)globalpar.bitrate + 1) * 1000000, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_LP_FREQ, (float)18e+6, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH, globalpar.hfp, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH, globalpar.hbp, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC, globalpar.hsa, ref errMsg, ref statusMsg));
                    //sw.WriteLine(globalpar.hsa + " " + globalpar.hbp + " " + globalpar.hfp + " " + globalpar.bitrate);
                     */
                }

            } while (globalpar.bitrate < globalpar.targetbitrate);

            //sw.Close();







        }

        private void backgroundWorker1_changed(object sender, ProgressChangedEventArgs e)
        {

            textboxhfp.Text = globalpar.hfp.ToString();
            textboxhbp.Text = globalpar.hbp.ToString();
            textboxhsa.Text = globalpar.hsa.ToString();
            textbox_hsfreq.Text = globalpar.bitrate.ToString();

        }
        public class globalpar // 全域變數
        {
            public static int hsa, hbp, hfp, hact, vsa, vbp, vfp, vact, fr, lanecnt, bitrate, targetbitrate, testnum, waittime, bwcount, inihsa, inihbp, inihfp, pixelformat, imagehigh, imagewidth, swingstate;
            public static string dutoutput, videotype;
            public static float hsbitrate;
            public static bool videorunning;
            public static int[] videosendmode = new int[6];

        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@opendutpath.FileName, true);
            byte[] DUTResp = new byte[0];
            PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
            //foreach (byte element in DUTResp)
            // {
            string hex = BitConverter.ToString(DUTResp).Replace("-", ",");
            textbox_statusmsg.Text = hex;
            sw.WriteLine(hex);
            sw.Close();




        }

        private void button6_Click(object sender, EventArgs e)
        {
            string pathFile = @"D:\test";

            Excel.Application excelApp;
            Excel._Workbook wBook;
            Excel._Worksheet wSheet;
            Excel.Range wRange;
            // 開啟一個新的應用程式
            excelApp = new Excel.Application();

            // 讓Excel文件可見
            excelApp.Visible = true;

            // 停用警告訊息
            excelApp.DisplayAlerts = false;

            // 加入新的活頁簿
            excelApp.Workbooks.Add(Type.Missing);

            // 引用第一個活頁簿
            wBook = excelApp.Workbooks[1];

            // 設定活頁簿焦點
            wBook.Activate();

            try
            {
                // 引用第一個工作表
                wSheet = (Excel._Worksheet)wBook.Worksheets[1];

                // 命名工作表的名稱
                wSheet.Name = "工作表測試";

                // 設定工作表焦點
                wSheet.Activate();

                excelApp.Cells[1, 1] = "Excel測試";

                // 設定第1列資料
                excelApp.Cells[1, 1] = "名稱";
                excelApp.Cells[1, 2] = "數量";
                // 設定第1列顏色
                wRange = wSheet.Range[wSheet.Cells[1, 1], wSheet.Cells[1, 2]];
                wRange.Select();
                wRange.Font.Color = ColorTranslator.ToOle(Color.White);
                wRange.Interior.Color = ColorTranslator.ToOle(Color.DimGray);

                // 設定第2列資料
                excelApp.Cells[2, 1] = "AA";
                excelApp.Cells[2, 2] = "10";

                // 設定第3列資料
                excelApp.Cells[3, 1] = "BB";
                excelApp.Cells[3, 2] = "20";

                // 設定第4列資料
                excelApp.Cells[4, 1] = "CC";
                excelApp.Cells[4, 2] = "30";

                // 設定第5列資料
                excelApp.Cells[5, 1] = "總計";
                // 設定總和公式 =SUM(B2:B4)
                excelApp.Cells[5, 2].Formula = string.Format("=SUM(B{0}:B{1})", 2, 4);
                // 設定第5列顏色
                wRange = wSheet.Range[wSheet.Cells[5, 1], wSheet.Cells[5, 2]];
                wRange.Select();
                wRange.Font.Color = ColorTranslator.ToOle(Color.Red);
                wRange.Interior.Color = ColorTranslator.ToOle(Color.Yellow);

                // 自動調整欄寬
                wRange = wSheet.Range[wSheet.Cells[1, 1], wSheet.Cells[5, 2]];
                wRange.Select();
                wRange.Columns.AutoFit();

                try
                {
                    //另存活頁簿
                    wBook.SaveAs(pathFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    Console.WriteLine("儲存文件於 " + Environment.NewLine + pathFile);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("儲存檔案出錯，檔案可能正在使用" + Environment.NewLine + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("產生報表時出錯！" + Environment.NewLine + ex.Message);
            }

            //關閉活頁簿
            wBook.Close(false, Type.Missing, Type.Missing);

            //關閉Excel
            excelApp.Quit();

            //釋放Excel資源
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            wBook = null;
            wSheet = null;
            wRange = null;
            excelApp = null;
            GC.Collect();


        }

        private void btn_openautotest_Click(object sender, EventArgs e)
        {
            globalpar.videorunning = true;
            if (textbox_inirpc.Text == "" || textboxrpcsave.Text == "" || textbox_videopicpath.Text == "")
            {
                if (MessageBox.Show("有東西忘記選取,是否繼續", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    goto nothing;
                }
            }
            if (checkedListBox2.GetItemChecked(0))
            {
                globalpar.pixelformat = 24;
            }
            else
            {
                if (checkedListBox2.GetItemChecked(1))
                {
                    globalpar.pixelformat = 18;
                }
                else
                {
                    if (checkedListBox2.GetItemChecked(2))
                    {
                        globalpar.pixelformat = 16;
                    }
                    else
                    {
                        goto nothing;
                    }
                }
            }

            if (checkedListBox1.GetItemChecked(0))
            {
                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VERTICAL_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_BURST_MODE, 0, ref errMsg, ref statusMsg)); //event mode
                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_PULSE_MODE, 0, ref errMsg, ref statusMsg)); //non burst event mode
                globalpar.videotype = "LP blanking nunburst event";

                checkedListBox1.SetItemChecked(0, false);
            }
            else
            {
                if (checkedListBox1.GetItemChecked(1))
                {
                    PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VERTICAL_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_BURST_MODE, 0, ref errMsg, ref statusMsg)); //event mode
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_PULSE_MODE, 1, ref errMsg, ref statusMsg)); //non burst event mode
                    globalpar.videotype = "LP blanking nunburst pulse";
                    checkedListBox1.SetItemChecked(1, false);
                }
                else
                {
                    if (checkedListBox1.GetItemChecked(2))
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VERTICAL_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_BURST_MODE, 1, ref errMsg, ref statusMsg)); //event mode
                        PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_PULSE_MODE, 0, ref errMsg, ref statusMsg)); //non burst event mode
                        globalpar.videotype = "LP blanking burst event";
                        checkedListBox1.SetItemChecked(2, false);
                    }
                    else
                    {
                        if (checkedListBox1.GetItemChecked(3))
                        {
                            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC_BLANKING_MODE, 2, ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH_BLANKING_MODE, 2, ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH_BLANKING_MODE, 2, ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VERTICAL_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_BURST_MODE, 0, ref errMsg, ref statusMsg)); //event mode
                            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_PULSE_MODE, 0, ref errMsg, ref statusMsg)); //non burst event mode
                            globalpar.videotype = "HS blanking nunburst event";
                            checkedListBox1.SetItemChecked(3, false);
                        }
                        else
                        {
                            if (checkedListBox1.GetItemChecked(4))
                            {
                                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC_BLANKING_MODE, 2, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH_BLANKING_MODE, 2, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH_BLANKING_MODE, 2, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VERTICAL_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_BURST_MODE, 0, ref errMsg, ref statusMsg)); //event mode
                                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_PULSE_MODE, 1, ref errMsg, ref statusMsg)); //non burst event mode
                                globalpar.videotype = "HS blanking nunburst pulse";
                                checkedListBox1.SetItemChecked(4, false);
                            }
                            else
                            {
                                if (checkedListBox1.GetItemChecked(5))
                                {
                                    PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC_BLANKING_MODE, 2, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH_BLANKING_MODE, 2, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH_BLANKING_MODE, 2, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VERTICAL_BLANKING_MODE, 1, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_BURST_MODE, 1, ref errMsg, ref statusMsg)); //event mode
                                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_PULSE_MODE, 0, ref errMsg, ref statusMsg)); //non burst event mode
                                    globalpar.videotype = "HS blanking burst pulse";
                                    checkedListBox1.SetItemChecked(5, false);
                                }
                                else
                                {
                                    goto nothing;
                                }
                            }
                        }
                    }

                }
            }

            textbox_fortest.Text = "";
            /*
            if (checkBox_webcam.Checked == true)
                cap = new Capture(0);
            else
            {

            }
            */
            if (btn_4lane.Checked == true)
            {
                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 4, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                globalpar.lanecnt = 4;
            }
            else if (btn_3lane.Checked == true)
            {
                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 3, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                globalpar.lanecnt = 3;
            }
            else if (btn_2lane.Checked == true)
            {
                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 2, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                globalpar.lanecnt = 2;
            }
            else
            {
                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_LANE_CNT, 1, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                globalpar.lanecnt = 1;
            }
            PE(client.MIPICmd(RPCDefs.RPC_SCRIPT, 0, false, RPCDefs.DT_HS, 0, 0, 0, 0, openinirpc.FileName, null, ref errMsg, ref statusMsg)); //送initial code  
            globalpar.waittime = Convert.ToInt32(textboxwaittime.Text);
            globalpar.hsa = Convert.ToInt32(textboxhsa.Text);
            globalpar.inihsa = Convert.ToInt32(textboxhsa.Text);
            globalpar.hbp = Convert.ToInt32(textboxhbp.Text);
            globalpar.inihbp = Convert.ToInt32(textboxhbp.Text);
            globalpar.hfp = Convert.ToInt32(textboxhfp.Text);
            globalpar.inihfp = Convert.ToInt32(textboxhfp.Text);
            globalpar.vsa = Convert.ToInt32(textboxvsa.Text);
            globalpar.vbp = Convert.ToInt32(textboxvbp.Text);
            globalpar.vfp = Convert.ToInt32(textboxvfp.Text);
            globalpar.hact = Convert.ToInt32(textboxhact.Text);
            globalpar.vact = Convert.ToInt32(textboxvact.Text);
            globalpar.fr = Convert.ToInt32(textboxfr.Text);
            globalpar.targetbitrate = (Convert.ToInt32(textboxtagetbitrate.Text) / 2);
            globalpar.bitrate = ((globalpar.hsa + globalpar.hbp + globalpar.hfp + globalpar.hact) * (globalpar.vsa + globalpar.vbp + globalpar.vfp + globalpar.vact) * globalpar.pixelformat / globalpar.lanecnt * globalpar.fr / 1000000 / 2 + 1);
            textbox_hsfreq.Text = globalpar.bitrate.ToString();
            globalpar.dutoutput = opendutpath.FileName;
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VBPORCH, Convert.ToInt32(textboxvbp.Text), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VACTIVE, Convert.ToInt32(textboxvact.Text), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VFPORCH, Convert.ToInt32(textboxvfp.Text), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_VSYNC, Convert.ToInt32(textboxvsa.Text), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HACTIVE, Convert.ToInt32(textboxhact.Text), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH, Convert.ToInt32(textboxhfp.Text), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH, Convert.ToInt32(textboxhbp.Text), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC, Convert.ToInt32(textboxhsa.Text), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_FRAME_RATE, Convert.ToInt32(textboxfr.Text), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, ((float)globalpar.bitrate + 1) * 1000000, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_LP_FREQ, (float)18e+6, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));



            textbox_fortest2.Text = globalpar.pixelformat.ToString() + " bit  " + globalpar.videotype;
            if (button18.BackColor == Color.Lime)
            {
                if (this.backgroundskewswing.IsBusy != true)
                {
                    this.backgroundskewswing.WorkerReportsProgress = true;
                    this.backgroundskewswing.RunWorkerAsync();

                }
                else
                    textbox_fortest.Text = "buttonn fail";
            }
            else
            {
                if (this.backgroundWorker1.IsBusy != true)
                {
                    this.backgroundWorker1.WorkerReportsProgress = true;
                    this.backgroundWorker1.RunWorkerAsync();

                }
                else
                    textbox_fortest.Text = "buttonn fail";
            }


        nothing:
            {

            }


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                textbox_fortest.Text = "some error";
            else if (e.Cancelled)
                textbox_fortest.Text = "canelled";
            else
                hwreset();
            for (int i = 0; i < 6; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    textboxhsa.Text = globalpar.inihsa.ToString();
                    textboxhbp.Text = globalpar.inihbp.ToString();
                    textboxhfp.Text = globalpar.inihfp.ToString();
                    btn_openautotest.PerformClick();
                    return;
                }
            }
            for (int k = 0; k < 3; k++)
            {
                if (checkedListBox2.GetItemChecked(k))
                {
                    checkedListBox2.SetItemChecked(k, false);
                    callbackvideoset();
                    textboxhsa.Text = globalpar.inihsa.ToString();
                    textboxhbp.Text = globalpar.inihbp.ToString();
                    textboxhfp.Text = globalpar.inihfp.ToString();
                    btn_openautotest.PerformClick();
                    goto finish;
                }
                else
                    textbox_fortest.Text = "All done";
            }


        finish: textbox_fortest.Text = "no error";
        globalpar.videorunning = false;

        }

        private void backgroundWorkerwebcam_DoWork(object sender, DoWorkEventArgs e)
        {
            cap = new Capture(0);
            for (; ; )
            {
                if (backgroundWorkerwebcam.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    try
                    {
                        backgroundWorkerwebcam.ReportProgress(0);
                        Application.DoEvents();
                        ////在迴圈的時候如果想要及時反映最好加這段
                        System.Threading.Thread.Sleep(200);
                    }
                    catch (Exception)
                    {
                        e.Cancel = true;
                        break;
                    }
                }
            }


        }

        private void backgroundWorkerwebcam_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //cap = new Capture(0);
            Image<Bgr, Byte> camimage = cap.QueryFrame();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = camimage.Bitmap;
            //pictureBox1.Image.Save("d:\\Pg3a\\" + textbox_hsfreq.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }

        private void btn_stopwebcam_Click(object sender, EventArgs e)
        {
            this.backgroundWorkerwebcam.WorkerReportsProgress = false;
            this.backgroundWorkerwebcam.CancelAsync(); //中斷背景程式
            this.backgroundWorkerwebcam.Dispose();

        }
        private void sendvideoloop()
        {
            PE(client.MIPICmd(RPCDefs.PACKED_PIXEL_STREAM_888, 0, false, RPCDefs.DT_HS, 0, 1, 0, 0, textbox_videopicpath.Text, null, ref errMsg, ref statusMsg));
            System.Threading.Thread.Sleep(globalpar.waittime);

        }

        private void hfploop()
        {
            if (globalpar.bitrate < globalpar.targetbitrate)
            {

                globalpar.bitrate = ((globalpar.hsa + globalpar.hbp + globalpar.hfp + globalpar.hact) * (globalpar.vsa + globalpar.vbp + globalpar.vfp + globalpar.vact) * globalpar.pixelformat / globalpar.lanecnt * globalpar.fr / 1000000 / 2 + 1);
                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, ((float)globalpar.bitrate + 1) * 1000000, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_LP_FREQ, (float)18e+6, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH, globalpar.hfp, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH, globalpar.hbp, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC, globalpar.hsa, ref errMsg, ref statusMsg));
                globalpar.hfp = globalpar.hfp + 20;
                textboxhfp.Text = globalpar.hfp.ToString();
                textbox_hsfreq.Text = globalpar.bitrate.ToString();
            }


        }


        private void hwreset()
        {
            UInt32 DevNum = 0;
            UInt32 devicenumber = 0;
            StringBuilder DevStr = new StringBuilder(SLUSBXpressDLL.SI_MAX_DEVICE_STRLEN);
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_GetNumDevices(ref DevNum);
            IntPtr hUSBDevice2 = this.Handle;
            byte[] buffer = new byte[6];
            byte[] cmdreset = new byte[1];
            cmdreset[0] = 0x05;
            Int32 IOBufSize = 12;
            Byte[] IOBuf = new Byte[IOBufSize];
            uint BytesSucceed = 0;




        heading:
            {

            }

            if (SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS)
            {
                SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_GetProductString(devicenumber, DevStr, SLUSBXpressDLL.SI_RETURN_SERIAL_NUMBER);
                if (SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS)
                {
                    SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_SetTimeouts(10000, 10000);

                    SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Open(0, ref hUSBDevice2);
                    if (DevStr.ToString() != "ar5w2")
                    {
                        SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Write(hUSBDevice2, cmdreset, SETUP_SIZE, ref BytesSucceed, 0);
                        Thread.Sleep(100);
                        SLUSBXpressDLL.SI_Close(hUSBDevice2);
                        goto heading;
                    }
                    SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_GetProductString(devicenumber, DevStr, SLUSBXpressDLL.SI_RETURN_SERIAL_NUMBER);
                    //SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Open(0, ref hUSBDevice2);
                    if (SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS)
                    {
                        buffer[0] = RESETPIN_MSG;
                        buffer[5] = 1;
                        SLUSBXpressDLL.Status = SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Write(hUSBDevice2, buffer, SETUP_SIZE, ref BytesSucceed, 0);
                        //if(SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS)
                        if ((BytesSucceed != SETUP_SIZE) || (SLUSBXpressDLL.Status != SLUSBXpressDLL.SI_SUCCESS))
                        {
                            MessageBox.Show("write fail");
                            Application.Exit();
                        }
                        else
                        {
                            buffer[0] = RESETPIN_MSG;
                            buffer[5] = 0;
                            SLUSBXpressDLL.Status = SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Write(hUSBDevice2, buffer, SETUP_SIZE, ref BytesSucceed, 0);
                            if ((BytesSucceed != SETUP_SIZE) || (SLUSBXpressDLL.Status != SLUSBXpressDLL.SI_SUCCESS))
                            {
                                MessageBox.Show("write fail");
                                Application.Exit();
                            }
                            else
                            {
                                buffer[0] = RESETPIN_MSG;
                                buffer[5] = 1;
                                SLUSBXpressDLL.Status = SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Write(hUSBDevice2, buffer, SETUP_SIZE, ref BytesSucceed, 0);
                                if ((BytesSucceed != SETUP_SIZE) || (SLUSBXpressDLL.Status != SLUSBXpressDLL.SI_SUCCESS))
                                {
                                    MessageBox.Show("write fail");
                                    Application.Exit();
                                }
                                else
                                {
                                    SLUSBXpressDLL.SI_Close(hUSBDevice2);
                                }

                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Fail");
                        return;
                    }


                }
                //status = SI_GetProductString(DeviceNumber, devStr, SI_RETURN_SERIAL_NUMBER);

            }

        }

        private void savewebcam()
        {
            Image<Bgr, Byte> camimage = cap.QueryFrame();
            pictureBox1.Image = camimage.Bitmap;
            pictureBox1.Image.Save("d:\\Pg3a\\" + globalpar.pixelformat + "bit" + globalpar.videotype + (Convert.ToInt32(textbox_hsfreq.Text) * 2).ToString() + "Mbps.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            cap.Dispose();
        }
        private delegate void DisplayImageDelegate(Bitmap Image);
        private void DisplayImage(Bitmap Image)
        {
            if (pictureBox1.InvokeRequired)
            {
                try
                {
                    DisplayImageDelegate DI = new DisplayImageDelegate(DisplayImage);
                    this.BeginInvoke(DI, new object[] { Image });
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                pictureBox1.Image = Image;
            }
        }
        private void callbackvideoset()
        {
            int count = 0;
            foreach (byte i in globalpar.videosendmode)
            {
                if (i == 1)
                {
                    checkedListBox1.SetItemChecked(count, true);
                    count += 1;
                }
                else
                {
                    checkedListBox1.SetItemChecked(count, false);
                    count += 1;
                }
            }
        }

        private void backgroundworker_skew_DoWork(object sender, DoWorkEventArgs e)
        {
            /*
            int bitrate = Convert.ToInt32(textbox_skewstart.Text);
            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, (float)(bitrate / 2 * 1E+6), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
             * */

            do
            {
                if (backgroundworker_skew.CancellationPending == true)
                {

                    e.Cancel = true;
                    break;


                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    backgroundworker_skew.ReportProgress(0);
                    skewloop();
                    /*
                    bitrate = bitrate + 50;
                    PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, (float)(bitrate / 2 * 1E+6), ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    */




                }

            } while (Convert.ToInt32(textbox_skewstart.Text) < Convert.ToInt32(textbox_skewend.Text));
        }

        private void backgroundworker_skew_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //label_skewui.Text = skewnow.ToString() + "UI";
            //label_skewtime.Text = skewtime.ToString() + "ps";
            textbox_skewstart.Text = (Convert.ToInt32(textbox_skewstart.Text) + 50).ToString();
        }

        private void btn_skewautotest_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter(opendutpath.FileName, true);
            //sw.WriteLine(DateTime.Now.ToShortTimeString() + "Skew autotest Strat......");
            //sw.Close();
            label_skewstate.Text = "目前Bite Rate";
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_BURST_MODE, 1, ref errMsg, ref statusMsg));
            if (this.backgroundworker_skew.IsBusy != true)
            {
                this.backgroundworker_skew.WorkerReportsProgress = true;
                this.backgroundworker_skew.RunWorkerAsync();

            }
            else
                textbox_fortest.Text = "buttonn fail";
        }
        private void skewloop()
        {
            //StreamWriter sw = new StreamWriter(@opendutpath.FileName, true);
            byte[] DUTResp = new byte[0];
            float skewnow = 0.05F;
            float skewbitrate = Convert.ToInt32(textbox_skewstart.Text);
            int skewend = Convert.ToInt32(textbox_skewend.Text);
            float ui = 1000000 / skewbitrate;
            byte[] data = new byte[4];
            data[0] = 0x55;
            data[1] = 0xAA;
            data[2] = 0x55;
            data[3] = 0xAA;
            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, (float)(skewbitrate / 2 * 1E+6), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
            for (int skewui = 1; skewui <= 20; skewui++)
            {
                float skewtime = ui * skewui / 20;
                skewnow = (float)skewui * 0.05F;
                //label_skewtime.Text = skewtime.ToString() + "ps";
                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.ENABLE_AUTO_SET_CLOCK_DELAY, 0, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SET_HS_DELAY, 4, skewtime * 1E-12F, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                PE(client.MIPICmd(RPCDefs.CUSTOM_COMMAND, 0, false, RPCDefs.DT_HS, 0, 0x39, 0, 0, "", data, ref errMsg, ref statusMsg));
                PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
                PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
                PE(client.PGRemoteCmd(RPCCmds.SAVE_DUT_RESPONSE, textboxrpcsave.Text, 100, skewbitrate.ToString() + " Mhz " + skewnow.ToString() + " UI" + measfluke(), 0, ref errMsg, ref statusMsg));
                //label_skewui.Text = skewnow.ToString() + "UI";
                Application.DoEvents();
                //sw.WriteLine(skewbitrate + skewnow + skewtime);
                //sw.Close();

            }







        }

        private void btn_skewstop_Click(object sender, EventArgs e)
        {
            this.backgroundworker_skew.WorkerReportsProgress = false;
            this.backgroundworker_swing.WorkerReportsProgress = false;
            this.backgroundworker_skew.CancelAsync(); //中斷背景程式
            this.backgroundworker_swing.CancelAsync(); //中斷背景程式
            this.backgroundworker_skew.Dispose();
            this.backgroundworker_swing.Dispose();
        }

        private void backgroundworker_skew_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                label_skewstate.Text = "發生錯誤";
            else if (e.Cancelled)
                label_skewstate.Text = "已手動取消";
            else
                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.ENABLE_AUTO_SET_CLOCK_DELAY, 1, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
            label_skewstate.Text = "起始Bit Rate";
        }

        private void btn_dislinkpg_Click(object sender, EventArgs e)
        {
            int rc = client.Connect("", 2799);
        }

        private void btn_exerpc_Click(object sender, EventArgs e)
        {
            openrpcpath.ShowDialog();
            string rpcfile = openrpcpath.FileName;
            PE(client.MIPICmd(RPCDefs.RPC_SCRIPT, 0, false, RPCDefs.DT_DEFAULT, 0, 0, 0, 0, rpcfile, null, ref errMsg, ref statusMsg));
        }

        private void button8_Click(object sender, EventArgs e)
        {




        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btn_selini_Click(object sender, EventArgs e)
        {
            openinirpc.ShowDialog();
            textbox_inirpc.Text = openinirpc.FileName;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    globalpar.videosendmode[i] = 1;
                }
                else
                    globalpar.videosendmode[i] = 0;
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textbox_fortest2.Text) + Convert.ToInt32(textbox_fortest3.Text);
            if (a % 2 != 0)
            {
                return;
            }
            else
            {
                textbox_fortest.Text = a.ToString();
            }
            textbox_fortest.Text = "GG";
            
        }
        private static void DataReceivedHandler(
            object sender,
            SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            //Console.WriteLine("Data Received:");
            MessageBox.Show(indata);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hwreset();

            //openinirpc.FileName;
        }

        private void backgroundworker_swing_DoWork(object sender, DoWorkEventArgs e)
        {
            globalpar.swingstate = 0;
            int bitrate = Convert.ToInt32(textbox_skewstart.Text);
            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, (float)(bitrate / 2 * 1E+6), ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));

            do
            {
                if (backgroundworker_swing.CancellationPending == true)
                {

                    e.Cancel = true;
                    break;


                }
                else
                {
                    if (globalpar.swingstate == 0)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 0.88f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, -0.04f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.16f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.swingstate == 1)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 0.88f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, 0.29f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.39f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.swingstate == 2)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 0.88f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, 0.21f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.47f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.swingstate == 3)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 0.88f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, 0.01f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.11f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.swingstate == 4)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 1.2f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, -0.04f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.16f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.swingstate == 5)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 1.2f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, 0.29f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.39f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.swingstate == 6)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 1.2f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, 0.21f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.47f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.swingstate == 7)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 1.2f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, 0.01f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.11f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.swingstate == 8)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 1.35f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, -0.04f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.16f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.swingstate == 9)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 1.35f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, 0.29f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.39f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.swingstate == 10)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 1.35f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, 0.21f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.47f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    else if (globalpar.swingstate == 11)
                    {
                        PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_LP_HIGH_VOLT, 1, 1.35f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, 0.01f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, 0.11f, ref errMsg, ref statusMsg));
                        PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    }
                    do
                    {
                        if (backgroundworker_swing.CancellationPending == true)
                        {
                            e.Cancel = true;
                            break;
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(1000);
                            backgroundworker_swing.ReportProgress(0);
                            swingloop();
                            bitrate = bitrate + 50;
                            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, (float)(bitrate / 2 * 1E+6), ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                        }
                    } while (Convert.ToInt32(textbox_skewstart.Text) < Convert.ToInt32(textbox_skewend.Text));






                }

            } while (globalpar.swingstate <= 12);
        }

        private void backgroundworker_swing_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundworker_swing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openfileautoset.ShowDialog();
            StreamWriter sw = new StreamWriter(openfileautoset.FileName);
            sw.WriteLine(textboxhsa.Text);
            sw.WriteLine(textboxhbp.Text);
            sw.WriteLine(textboxhfp.Text);
            sw.WriteLine(textboxhact.Text);
            sw.WriteLine(textboxvsa.Text);
            sw.WriteLine(textboxvbp.Text);
            sw.WriteLine(textboxvfp.Text);
            sw.WriteLine(textboxvact.Text);
            sw.WriteLine(textboxfr.Text);
            sw.WriteLine(textboxtagetbitrate.Text);
            sw.WriteLine(textboxwaittime.Text);
            sw.WriteLine(textbox_videopicpath.Text);
            sw.WriteLine(textbox_inirpc.Text);
            sw.WriteLine(textboxrpcsave.Text);
            sw.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string line;
            int i = 0;
            string[] setting = new string[14];
            openfileautoset.ShowDialog();
            if(openfileautoset.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                if (openfileautoset.OpenFile() != null)
                {

                }
                else
                    return;
            }
            catch (Exception ex)
            {
                return;
            }
            StreamReader sr = new StreamReader(openfileautoset.FileName);
            while ((line = sr.ReadLine()) != null)
            {

                setting[i] = line;
                i++;
            }
            textboxhsa.Text = setting[0];
            textboxhbp.Text = setting[1];
            textboxhfp.Text = setting[2];
            textboxhact.Text = setting[3];
            textboxvsa.Text = setting[4];
            textboxvbp.Text = setting[5];
            textboxvfp.Text = setting[6];
            textboxvact.Text = setting[7];
            textboxfr.Text = setting[8];
            textboxtagetbitrate.Text = setting[9];
            textboxwaittime.Text = setting[10];
            textbox_videopicpath.Text = setting[11];
            openvideopic.FileName = setting[11];
            textbox_inirpc.Text = setting[12];
            openinirpc.FileName = setting[12];
            textboxrpcsave.Text = setting[13];
            opendutpath.FileName = setting[13];
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = openvideopic.FileName;
        }

        private void backgroundworker_hsspeed_DoWork(object sender, DoWorkEventArgs e)
        {


            do
            {
                if (backgroundworker_hsspeed.CancellationPending == true)
                {

                    e.Cancel = true;
                    break;


                }
                else
                {
                    float bitrate = Convert.ToSingle(textbox_hsautostart.Text);
                    PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, (float)(bitrate / 2 * 1E+6), ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_LP_FREQ, (float)18e+6, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));

                    System.Threading.Thread.Sleep(1000);
                    backgroundworker_hsspeed.ReportProgress(0);


                }

            } while (Convert.ToInt32(textbox_hsautostart.Text) < Convert.ToInt32(textbox_hsautoend.Text));

        }

        private void backgroundworker_hsspeed_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            hsautoloop();
            textbox_hsautostart.Text = (Convert.ToInt32(textbox_hsautostart.Text) + 5).ToString();
        }

        private void backgroundworker_hsspeed_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        private void hsautoloop()
        {
            byte[] DUTResp = new byte[0];
            PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
            PE(client.MIPICmd(RPCDefs.DCS_LONG_WRITE, RPCDefs.WRITE_MEMORY_START, false, RPCDefs.DT_HS, 0, 0, (globalpar.imagehigh * globalpar.imagewidth * 3), 0, openvideopic.FileName, null, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.PG_RESTART, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.PG_RESTART, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.PG_RESTART, ref errMsg, ref statusMsg));
            PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
            PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SAVE_DUT_RESPONSE, textboxrpcsave.Text, 100, textbox_hsautostart.Text + " Mbps" + measfluke(), 0, ref errMsg, ref statusMsg));
            textbox_hsautostart.Text = (Convert.ToInt32(textbox_hsautostart.Text)).ToString();


        }

        private void button12_Click(object sender, EventArgs e)
        {
            PE(client.MIPICmd(RPCDefs.RPC_SCRIPT, 0, false, RPCDefs.DT_HS, 0, 0, 0, 0, openinirpc.FileName, null, ref errMsg, ref statusMsg)); //送initial code  
            StreamWriter sw = new StreamWriter(opendutpath.FileName, true);
            sw.WriteLine(DateTime.Now.ToShortTimeString() + "HS speed auto test start.......");
            sw.Close();

            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_BURST_MODE, 1, ref errMsg, ref statusMsg)); //event mode
            Image<Bgr, Byte> img1 = new Image<Bgr, byte>(openvideopic.FileName);
            globalpar.imagehigh = img1.Height;
            globalpar.imagewidth = img1.Width;
            //globalpar.imagehigh = 854;
            //globalpar.imagewidth = 480;
            PE(client.PGRemoteCmd(RPCCmds.SET_WM_PARTITION_LENGTH, globalpar.imagewidth * 30, ref errMsg, ref statusMsg));
            if (this.backgroundworker_hsspeed.IsBusy != true)
            {
                this.backgroundworker_hsspeed.WorkerReportsProgress = true;
                this.backgroundworker_hsspeed.RunWorkerAsync();

            }
            else
                textbox_fortest.Text = "buttonn fail";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.backgroundworker_hsspeed.WorkerReportsProgress = false;
            this.backgroundworker_hsspeed.CancelAsync(); //中斷背景程式
            this.backgroundworker_hsspeed.Dispose();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            openfiletestseq.ShowDialog();
            Thread goautoseq = new Thread(new ThreadStart(autoseq));
            goautoseq.Start();
        }

        private void settingFlukeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            for (int j = 1; j < 7; j++)
            {
                ((ComboBox)this.Controls.Find("combobox_portname" + j.ToString(), true)[0]).Items.AddRange(ports);
            }

            int portcount = ports.Length;
            /*
                // Display each port name to the console.

                combobox_portname1.Items.AddRange(ports);
                combobox_portname2.Items.AddRange(ports);
                combobox_portname3.Items.AddRange(ports);
                combobox_portname4.Items.AddRange(ports);
                combobox_portname5.Items.AddRange(ports);
                combobox_portname6.Items.AddRange(ports);
                
            
            if (portcount == 1)
            {
                combobox_portname1.Visible = true;
                btn_setfluke1.Visible = true;
            }
            else if (portcount ==2)
            {
                combobox_portname1.Visible = true;
                btn_setfluke1.Visible = true;
                combobox_portname2.Visible = true;
                btn_setfluke2.Visible = true;
            }
            else if (portcount ==3)
            {
                combobox_portname1.Visible = true;
                btn_setfluke1.Visible = true;
                combobox_portname2.Visible = true;
                btn_setfluke2.Visible = true;
                combobox_portname3.Visible = true;
                btn_setfluke3.Visible = true;
            }
            else if (portcount ==4)
            {
                combobox_portname1.Visible = true;
                btn_setfluke1.Visible = true;
                combobox_portname2.Visible = true;
                btn_setfluke2.Visible = true;
                combobox_portname3.Visible = true;
                btn_setfluke3.Visible = true;
                combobox_portname4.Visible = true;
                btn_setfluke4.Visible = true;
            }
            else if (portcount ==5)
            {
                combobox_portname1.Visible = true;
                btn_setfluke1.Visible = true;
                combobox_portname2.Visible = true;
                btn_setfluke2.Visible = true;
                combobox_portname3.Visible = true;
                btn_setfluke3.Visible = true;
                combobox_portname4.Visible = true;
                btn_setfluke4.Visible = true;
                combobox_portname5.Visible = true;
                btn_setfluke5.Visible = true;
            }
            else if (portcount ==6)
            {
                combobox_portname1.Visible = true;
                btn_setfluke1.Visible = true;
                combobox_portname2.Visible = true;
                btn_setfluke2.Visible = true;
                combobox_portname3.Visible = true;
                btn_setfluke3.Visible = true;
                combobox_portname4.Visible = true;
                btn_setfluke4.Visible = true;
                combobox_portname5.Visible = true;
                btn_setfluke5.Visible = true;
                combobox_portname6.Visible = true;
                btn_setfluke6.Visible = true;
            }
            */
            for (int i = 1; i <= portcount; i++)
            {
                ((ComboBox)this.Controls.Find("combobox_portname" + i.ToString(), true)[0]).Visible = true;
                ((Button)this.Controls.Find("btn_setfluke" + i.ToString(), true)[0]).Visible = true;
            }





        }

        private void btn_setfluke_Click(object sender, EventArgs e)
        {
            if (btn_setfluke1.BackColor == Color.Lime)
            {
                btn_setfluke1.BackColor = Color.Transparent;
            }
            else
            {
                if (combobox_portname1.SelectedItem != null)
                {
                    btn_setfluke1.BackColor = Color.Lime;
                    serialPort1.PortName = combobox_portname1.SelectedItem.ToString();
                }
            }
        }

        private void btn_setfluke2_Click(object sender, EventArgs e)
        {
            if (btn_setfluke2.BackColor == Color.Lime)
            {
                btn_setfluke2.BackColor = Color.Transparent;
            }
            else
            {
                if (combobox_portname2.SelectedItem != null)
                {
                    btn_setfluke2.BackColor = Color.Lime;
                    serialPort2.PortName = combobox_portname2.SelectedItem.ToString();
                }
            }
        }


        private void btn_setfluke3_Click(object sender, EventArgs e)
        {
            if (btn_setfluke3.BackColor == Color.Lime)
            {
                btn_setfluke3.BackColor = Color.Transparent;
            }
            else
            {
                if (combobox_portname3.SelectedItem != null)
                {
                    btn_setfluke3.BackColor = Color.Lime;
                    serialPort3.PortName = combobox_portname3.SelectedItem.ToString();
                }
            }
        }


        private void btn_setfluke4_Click(object sender, EventArgs e)
        {
            if (btn_setfluke4.BackColor == Color.Lime)
            {
                btn_setfluke4.BackColor = Color.Transparent;
            }
            else
            {
                if (combobox_portname4.SelectedItem != null)
                {
                    btn_setfluke4.BackColor = Color.Lime;
                    serialPort4.PortName = combobox_portname4.SelectedItem.ToString();
                }
            }
        }


        private void btn_setfluke5_Click(object sender, EventArgs e)
        {
            if (btn_setfluke5.BackColor == Color.Lime)
            {
                btn_setfluke5.BackColor = Color.Transparent;
            }
            else
            {
                if (combobox_portname5.SelectedItem != null)
                {
                    btn_setfluke5.BackColor = Color.Lime;
                    serialPort5.PortName = combobox_portname5.SelectedItem.ToString();
                }
            }
        }


        private void btn_setfluke6_Click(object sender, EventArgs e)
        {
            if (btn_setfluke6.BackColor == Color.Lime)
            {
                btn_setfluke6.BackColor = Color.Transparent;
            }
            else
            {
                if (combobox_portname6.SelectedItem != null)
                {
                    btn_setfluke6.BackColor = Color.Lime;
                    serialPort6.PortName = combobox_portname6.SelectedItem.ToString();
                }
            }
        }

        private string flukeread(int i)
        {

            char[] delimiterChars = {
                ',', ' ', '\r', '\n'
            };
            string readfluke = null;
            if (i == 1)
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
                serialPort1.WriteLine("QM\r");
                System.Threading.Thread.Sleep(50);
                readfluke = serialPort1.ReadExisting();
                serialPort1.Close();



            }
            else if (i == 2)
            {
                if (!serialPort2.IsOpen)
                {
                    serialPort2.Open();
                }
                serialPort2.WriteLine("QM\r");
                System.Threading.Thread.Sleep(50);
                readfluke = serialPort2.ReadExisting();
                serialPort2.Close();


            }
            else if (i == 3)
            {
                if (!serialPort3.IsOpen)
                {
                    serialPort3.Open();
                }
                serialPort3.WriteLine("QM\r");
                System.Threading.Thread.Sleep(50);
                readfluke = serialPort3.ReadExisting();
                serialPort3.Close();


            }
            else if (i == 4)
            {
                if (!serialPort4.IsOpen)
                {
                    serialPort4.Open();
                }
                serialPort4.WriteLine("QM\r");
                System.Threading.Thread.Sleep(50);
                readfluke = serialPort4.ReadExisting();
                serialPort4.Close();


            }
            else if (i == 5)
            {
                if (!serialPort5.IsOpen)
                {
                    serialPort5.Open();
                }
                serialPort5.WriteLine("QM\r");
                System.Threading.Thread.Sleep(50);
                readfluke = serialPort5.ReadExisting();
                serialPort5.Close();

            }
            else if (i == 6)
            {
                if (!serialPort6.IsOpen)
                {
                    serialPort6.Open();
                }
                serialPort6.WriteLine("QM\r");
                System.Threading.Thread.Sleep(50);
                readfluke = serialPort6.ReadExisting();
                serialPort6.Close();

            }
            if (readfluke == null || readfluke == "")
            {
                /*
                string[] words = readfluke.Split(delimiterChars);
                double flukedata = Convert.ToDouble(words[1]);
                return flukedata.ToString() + " " + words[2];
                 * */
                return " ";
            }
            else
            {
                string[] words = readfluke.Split(delimiterChars);
                double flukedata = Convert.ToDouble(words[1]);
                return flukedata.ToString() + " " + words[2];
            }








        }

        private void button11_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(opendutpath.FileName, true);
            sw.WriteLine(DateTime.Now.ToShortTimeString() + "Swing autotest Strat......");
            sw.Close();
            label_skewstate.Text = "目前Bite Rate";
            PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_ENABLE_DSI_BURST_MODE, 1, ref errMsg, ref statusMsg));
            if (this.backgroundworker_swing.IsBusy != true)
            {
                this.backgroundworker_swing.WorkerReportsProgress = true;
                this.backgroundworker_swing.RunWorkerAsync();

            }
            else
                textbox_fortest.Text = "buttonn fail";
        }

        private string measfluke()
        {
            string a = "";
            for (int i = 1; i < 7; i++)
            {
                //if(this.Controls.Find(("btn_setfluke" + i.ToString) , true).color;
                if (((Button)this.Controls.Find("btn_setfluke" + i.ToString(), true)[0]).BackColor == Color.Lime)
                {
                    a = a + " " + flukeread(i);
                }


            }
            return a;
        }

        private string getdutandvalue()
        {

            byte[] DUTResp = new byte[0];
            PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));

            string hex = BitConverter.ToString(DUTResp).Replace("-", ",");
            return hex;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string pathFile = @"D:\test";

            Excel.Application excelApp;
            Excel._Workbook wBook;
            Excel._Worksheet wSheet;
            Excel.Range wRange;
            // 開啟一個新的應用程式
            excelApp = new Excel.Application();

            // 讓Excel文件可見
            excelApp.Visible = true;

            // 停用警告訊息
            excelApp.DisplayAlerts = false;

            // 加入新的活頁簿
            excelApp.Workbooks.Add(Type.Missing);

            // 引用第一個活頁簿
            wBook = excelApp.Workbooks[1];

            // 設定活頁簿焦點
            wBook.Activate();

            try
            {
                // 引用第一個工作表
                wSheet = (Excel._Worksheet)wBook.Worksheets[1];

                // 命名工作表的名稱
                wSheet.Name = "工作表測試";

                // 設定工作表焦點
                wSheet.Activate();

                excelApp.Cells[1, 1] = "Excel測試";

                // 設定第1列資料
                excelApp.Cells[1, 1] = "名稱";
                excelApp.Cells[1, 2] = "數量";
                // 設定第1列顏色
                wRange = wSheet.Range[wSheet.Cells[1, 1], wSheet.Cells[1, 2]];
                wRange.Select();
                wRange.Font.Color = ColorTranslator.ToOle(Color.White);
                wRange.Interior.Color = ColorTranslator.ToOle(Color.DimGray);

                // 設定第2列資料
                excelApp.Cells[2, 1] = "AA";
                excelApp.Cells[2, 2] = "10";
                if (getbta() == "01-84")
                {
                    excelApp.Cells[5, 5] = "Pass";
                }
                // 設定第3列資料
                excelApp.Cells[3, 1] = "BB";
                excelApp.Cells[3, 2] = "20";

                // 設定第4列資料
                excelApp.Cells[4, 1] = "CC";
                excelApp.Cells[4, 2] = "30";

                // 設定第5列資料
                excelApp.Cells[5, 1] = "總計";
                // 設定總和公式 =SUM(B2:B4)
                excelApp.Cells[5, 2].Formula = string.Format("=SUM(B{0}:B{1})", 2, 4);
                // 設定第5列顏色
                wRange = wSheet.Range[wSheet.Cells[5, 1], wSheet.Cells[5, 2]];
                wRange.Select();
                wRange.Font.Color = ColorTranslator.ToOle(Color.Red);
                wRange.Interior.Color = ColorTranslator.ToOle(Color.Yellow);

                // 自動調整欄寬
                wRange = wSheet.Range[wSheet.Cells[1, 1], wSheet.Cells[5, 2]];
                wRange.Select();
                wRange.Columns.AutoFit();

                try
                {
                    //另存活頁簿
                    wBook.SaveAs(pathFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    Console.WriteLine("儲存文件於 " + Environment.NewLine + pathFile);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("儲存檔案出錯，檔案可能正在使用" + Environment.NewLine + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("產生報表時出錯！" + Environment.NewLine + ex.Message);
            }

            //關閉活頁簿
            wBook.Close(false, Type.Missing, Type.Missing);

            //關閉Excel
            excelApp.Quit();

            //釋放Excel資源
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            wBook = null;
            wSheet = null;
            wRange = null;
            excelApp = null;
            GC.Collect();

        }
        private void autoseq()
        {
            string autoseq;

            StreamReader sr = new StreamReader(openfiletestseq.FileName);
            while (!sr.EndOfStream)
            {
                autoseq = sr.ReadLine();
                char[] delimiterChars = {
                    ' '
                };
                string[] words = autoseq.Split(delimiterChars);
                if (words[0] == "SETINI")
                {
                    openinirpc.FileName = words[1];
                    textbox_inirpc.Text = words[1];

                }
                if (words[0] == "HWRST")
                {
                    hwreset();
                }
                if (words[0] == "VIDEOSTART")
                {
                    btn_openautotest.PerformClick();
                    Thread.Sleep(10000);
                    do
                        Thread.Sleep(10000);
                    while (this.backgroundWorker1.IsBusy == true);
                    textbox_fortest.Text = "OK";
                }
                if (words[0] == "SETVIDEO")
                {
                    textboxhsa.Text = words[1];
                    textboxhbp.Text = words[2];
                    textboxhfp.Text = words[3];
                    textboxhact.Text = words[4];
                    textboxvsa.Text = words[5];
                    textboxvbp.Text = words[6];
                    textboxvfp.Text = words[7];
                    textboxvact.Text = words[8];
                    if(words[9] == "1")
                    {
                        btn_1lane.Checked = true;
                    }
                    else if (words[9] == "2")
                    {
                        btn_2lane.Checked = true;
                    }
                    else if (words[9] == "3")
                    {
                        btn_3lane.Checked = true;
                    }
                    else
                    {
                        btn_4lane.Checked = true;
                    }

                }
                if (words[0] == "SKEWSTART")
                {
                    btn_skewautotest.PerformClick();
                    Thread.Sleep(10000);
                    do
                        Thread.Sleep(1000);
                    while (this.backgroundworker_skew.IsBusy == true);

                }
                if (words[0] == "SWINGSTART")
                {
                    button11.PerformClick();
                    do
                        Thread.Sleep(1000);
                    while (this.backgroundworker_swing.IsBusy == true);

                }
                if (words[0] == "DONE")
                {
                    textbox_fortest.Text = "done";
                }
                if (words[0] == "SETVIDEOITEM")
                {
                    for (int i = 1 ; i<words.Length ; i++)
                    {
                        if (words[i] == "24BIT")
                        {
                            checkedListBox2.SetItemChecked(0,true);
                        }
                        if (words[i] == "18BIT")
                        {
                            checkedListBox2.SetItemChecked(1, true);
                        }
                        if (words[i] == "16BIT")
                        {
                            checkedListBox2.SetItemChecked(2, true);
                        }
                        if (words[i] == "LP_EVENT")
                        {
                            checkedListBox1.SetItemChecked(0, true);
                        }
                        if (words[i] == "LP_PULSE")
                        {
                            checkedListBox1.SetItemChecked(1, true);
                        }
                        if (words[i] == "LP_BURST")
                        {
                            checkedListBox1.SetItemChecked(2, true);
                        }
                        if (words[i] == "HS_EVENT")
                        {
                            checkedListBox1.SetItemChecked(3, true);
                        }
                        if (words[i] == "HS_PULSE")
                        {
                            checkedListBox1.SetItemChecked(4, true);
                        }
                        if (words[i] == "HS_BURST")
                        {
                            checkedListBox1.SetItemChecked(5, true);
                        }
                    }
                }

            }
            sr.Close();
        }

        private void givetextbox(string itemname, string text)
        {

            TextBox tbx = this.Controls.Find(itemname, true).FirstOrDefault() as TextBox;

            if (tbx.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(givetextbox);
                this.Invoke(d, new object[] {
                    text
                });
            }
            else
            {
                tbx.Text = text;
            }


        }

        private void button16_Click(object sender, EventArgs e)
        {

            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void swingloop()
        {
            byte[] DUTResp = new byte[0];
            PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
            PE(client.MIPICmd(RPCDefs.DCS_LONG_WRITE, RPCDefs.WRITE_MEMORY_START, false, RPCDefs.DT_HS, 0, 0, (globalpar.imagehigh * globalpar.imagewidth * 3), 0, openvideopic.FileName, null, ref errMsg, ref statusMsg));
            PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
            PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
            PE(client.PGRemoteCmd(RPCCmds.SAVE_DUT_RESPONSE, textboxrpcsave.Text, 100, textbox_hsautostart.Text + " Mbps" + measfluke(), 0, ref errMsg, ref statusMsg));
            textbox_hsautostart.Text = (Convert.ToInt32(textbox_hsautostart.Text)).ToString();


        }

        private void btn_swingskewauto_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@opendutpath.FileName, true);
            float bitrate = 450e+6F;
            float targetbitrate = 1500e+6F;
            float[] cmvolt = new float[3] {
                0.07F, 0.2F, 0.33F
            };
            float[] difvolt = new float[5] {
                0.1F, 0.14F, 0.16F, 0.2F, 0.27F
            };



            float ui = 1F / bitrate;
            for (int i = 0; i < 3; i++) // CM volt
            {
                for (int j = 0; j < 5; j++) //diff volt
                {
                    float bitratenow = bitrate;
                    while (bitratenow <= targetbitrate)
                    {

                        sw.WriteLine("//Set CMvolt = " + cmvolt[i] + " V " + "diffvolt" + difvolt[j] + " V ");
                        sw.WriteLine("#START_EDIT_CONFIG");
                        sw.WriteLine("# SET_HS_LOW_VOLT 0 " + (cmvolt[i] - difvolt[j]));
                        sw.WriteLine("# SET_HS_HIGH_VOLT 0 " + (cmvolt[i] + difvolt[j]));
                        sw.WriteLine("# END_EDIT_CONFIG");
                        for (float k = 1; k <= 19; k++)
                        {
                            float skew = 1F / bitratenow / 20 * k;
                            //sw.WriteLine("bitrate = " + bitrate + "SKEW = " + k*0.05F +"UI");
                            //sw.WriteLine(skew);
                            sw.WriteLine("#START_EDIT_CONFIG");
                            sw.WriteLine("# SET_HS_FREQ " + bitratenow);
                            sw.WriteLine("# SET_HS_DELAY 4 " + skew);
                            sw.WriteLine("# END_EDIT_CONFIG");
                            sw.WriteLine("# SEND_MIPI_CMD BTA 0 1 DT_DEFAULT 0 0 0 0  NULL ");
                            sw.WriteLine("# GET_DUT_RESPONSE 0");
                            sw.WriteLine("# SAVE_DUT_RESPONSE " + bitratenow / (1e+6) + "Mbps " + k * 0.05F + "UI");

                        }
                        bitratenow = bitratenow + (50e+6F);

                    }
                }
            }

            sw.Close();
        }

        private string getbta()
        {
            string btaout = "";
            byte[] DUTResp = new byte[0];
            PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
            PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
            //foreach (byte element in DUTResp)
            // {
            string hex = BitConverter.ToString(DUTResp);
            btaout = btaout + hex;

            return btaout;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            float bitrate = 450e+6F;
            float targetbitrate = 1500e+6F;
            float[] cmvolt = new float[3] {
                0.07F, 0.2F, 0.33F
            };
            float[] difvolt = new float[5] {
                0.14F, 0.16F, 0.22F, 0.28F,0.1F
            };
            float ui = 1F / bitrate;
            string pathFile = @"D:\test2";

            Excel.Application excelApp;
            Excel._Workbook wBook;
            Excel._Worksheet wSheet;
            Excel.Range wRange;
            // 開啟一個新的應用程式
            excelApp = new Excel.Application();

            // 讓Excel文件可見
            excelApp.Visible = true;

            // 停用警告訊息
            excelApp.DisplayAlerts = false;

            // 加入新的活頁簿
            excelApp.Workbooks.Add(Type.Missing);

            // 引用第一個活頁簿
            wBook = excelApp.Workbooks[1];

            // 設定活頁簿焦點
            wBook.Activate();
            try
            {
                // 引用第一個工作表
                wSheet = (Excel._Worksheet)wBook.Worksheets[1];

                // 命名工作表的名稱
                wSheet.Name = "command mode";

                // 設定工作表焦點
                
                wSheet = (Excel._Worksheet)wBook.Worksheets[2];
                wSheet.Name = "55 AA";
                wSheet = (Excel._Worksheet)wBook.Worksheets[1];
                wSheet.Activate();

                for (int i = 0; i < 3; i++) // CM volt
                {
                    for (int p = 3; p <= 21; p++)
                    {
                        excelApp.Cells[p + (i * 21), 1] = "Skew = " + (0.05 * (p - 2)) + "UI";
                        wSheet = (Excel._Worksheet)wBook.Worksheets[2];
                        wSheet.Activate();
                        excelApp.Cells[p + (i * 21), 1] = "Skew = " + (0.05 * (p - 2)) + "UI";
                        wSheet = (Excel._Worksheet)wBook.Worksheets[1];
                        wSheet.Activate();
                    }
                    for (int j = 0; j < 5; j++) //diff volt
                    {
                        excelApp.Cells[2 + (i * 21), j + 2] = "CM_volt = " + cmvolt[i] + " mV , Diff_volt = " + difvolt[j] + " mV ";
                        float bitratenow = bitrate;
                        while (bitratenow <= targetbitrate)
                        {


                            PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.ENABLE_AUTO_SET_CLOCK_DELAY, 0, ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, (cmvolt[i] - difvolt[j]*2), ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, (cmvolt[i] + difvolt[j]*2), ref errMsg, ref statusMsg));
                            PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                            for (float k = 1; k <= 19; k++)
                            {
                                float skew = 1F / bitratenow / 20 * k;
                                //sw.WriteLine("bitrate = " + bitrate + "SKEW = " + k*0.05F +"UI");
                                //sw.WriteLine(skew);

                                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, bitratenow / 2, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_HS_DELAY, 4, skew, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                getbta();
                                PE(client.PGRemoteCmd(RPCCmds.SAVE_DUT_RESPONSE, textboxrpcsave.Text, 100, "bitrate = " + bitrate + "SKEW = " + k * 0.05F + "UI", 0, ref errMsg, ref statusMsg));
                                byte[] data = new byte[4];
                                data[0] = 0x55;
                                data[1] = 0xAA;
                                data[2] = 0x55;
                                data[3] = 0xAA;
                                //PE(client.MIPICmd(RPCDefs.CUSTOM_COMMAND, 0, false, RPCDefs.DT_HS, 0, 0x39, 0, 0, "", data, ref errMsg, ref statusMsg));
                                PE(client.MIPICmd(RPCDefs.DCS_LONG_WRITE, RPCDefs.WRITE_MEMORY_START, false, RPCDefs.DT_HS, 0, 0, (globalpar.imagehigh * globalpar.imagewidth * 3), 0, openvideopic.FileName, null, ref errMsg, ref statusMsg));
                                if (getbta() == "01-84")
                                {
                                    excelApp.Cells[k + 2 + (i * 21), j + 2] = bitratenow;
                                    
                                }
                                PE(client.MIPICmd(RPCDefs.CUSTOM_COMMAND, 0, false, RPCDefs.DT_HS, 0, 0x39, 0, 0, "", data, ref errMsg, ref statusMsg));
                                if (getbta() == "01-84")
                                {
                                    wSheet = (Excel._Worksheet)wBook.Worksheets[2];
                                    wSheet.Activate();
                                    excelApp.Cells[k + 2 + (i * 21), j + 2] = bitratenow;
                                    wSheet = (Excel._Worksheet)wBook.Worksheets[1];
                                    wSheet.Activate();
                                }
                                hwreset();
                            }
                            bitratenow = bitratenow + (50e+6F);

                        }
                    }
                }






                // 自動調整欄寬
                wRange = wSheet.Range[wSheet.Cells[1, 1], wSheet.Cells[5, 2]];
                wRange.Select();
                wRange.Columns.AutoFit();

                try
                {
                    //另存活頁簿
                    wBook.SaveAs(pathFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    Console.WriteLine("儲存文件於 " + Environment.NewLine + pathFile);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("儲存檔案出錯，檔案可能正在使用" + Environment.NewLine + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("產生報表時出錯！" + Environment.NewLine + ex.Message);
            }

            //關閉活頁簿
            wBook.Close(false, Type.Missing, Type.Missing);

            //關閉Excel
            excelApp.Quit();

            //釋放Excel資源
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            wBook = null;
            wSheet = null;
            wRange = null;
            excelApp = null;
            GC.Collect();


        }

        private void checkBox_webcam_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void regcompare()
        {
            string regcompare;

            StreamReader sr = new StreamReader(openfiletestseq.FileName);
            while (!sr.EndOfStream)
            {
                regcompare = sr.ReadLine();
                char[] delimiterChars = {
                    ' '
                };
                string[] words = regcompare.Split(delimiterChars);
                if (words[0] == "SETINI")
                {
                    openinirpc.FileName = words[1];
                    textbox_inirpc.Text = words[1];

                }
                if (words[0] == "HWRST")
                {
                    hwreset();
                }
                if (words[0] == "VIDEOSTART")
                {
                    btn_openautotest.PerformClick();
                    Thread.Sleep(10000);
                    do
                        Thread.Sleep(10000);
                    while (this.backgroundWorker1.IsBusy == true);
                    textbox_fortest.Text = "OK";
                }
                if (words[0] == "SETVIDEO")
                {
                    textboxhsa.Text = words[1];
                    textboxhbp.Text = words[2];
                    textboxhfp.Text = words[3];
                    textboxhact.Text = words[4];
                    textboxvsa.Text = words[5];
                    textboxvbp.Text = words[6];
                    textboxvfp.Text = words[7];
                    textboxvact.Text = words[8];
                    if (words[9] == "1")
                    {
                        btn_1lane.Checked = true;
                    }
                    else if (words[9] == "2")
                    {
                        btn_2lane.Checked = true;
                    }
                    else if (words[9] == "3")
                    {
                        btn_3lane.Checked = true;
                    }
                    else
                    {
                        btn_4lane.Checked = true;
                    }

                }
                if (words[0] == "SKEWSTART")
                {
                    btn_skewautotest.PerformClick();
                    Thread.Sleep(10000);
                    do
                        Thread.Sleep(1000);
                    while (this.backgroundworker_skew.IsBusy == true);

                }
                if (words[0] == "SWINGSTART")
                {
                    button11.PerformClick();
                    do
                        Thread.Sleep(1000);
                    while (this.backgroundworker_swing.IsBusy == true);

                }
                if (words[0] == "DONE")
                {
                    textbox_fortest.Text = "done";
                }
                if (words[0] == "SETVIDEOITEM")
                {
                    for (int i = 1; i < words.Length; i++)
                    {
                        if (words[i] == "24BIT")
                        {
                            checkedListBox2.SetItemChecked(0, true);
                        }
                        if (words[i] == "18BIT")
                        {
                            checkedListBox2.SetItemChecked(1, true);
                        }
                        if (words[i] == "16BIT")
                        {
                            checkedListBox2.SetItemChecked(2, true);
                        }
                        if (words[i] == "LP_EVENT")
                        {
                            checkedListBox1.SetItemChecked(0, true);
                        }
                        if (words[i] == "LP_PULSE")
                        {
                            checkedListBox1.SetItemChecked(1, true);
                        }
                        if (words[i] == "LP_BURST")
                        {
                            checkedListBox1.SetItemChecked(2, true);
                        }
                        if (words[i] == "HS_EVENT")
                        {
                            checkedListBox1.SetItemChecked(3, true);
                        }
                        if (words[i] == "HS_PULSE")
                        {
                            checkedListBox1.SetItemChecked(4, true);
                        }
                        if (words[i] == "HS_BURST")
                        {
                            checkedListBox1.SetItemChecked(5, true);
                        }
                    }
                }

            }
            sr.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Lime;
        }

        private void backgroundskewswing_DoWork(object sender, DoWorkEventArgs e)
        {
            //StreamWriter sw = new StreamWriter(@opendutpath.FileName, true);
            globalpar.testnum = 0;
            byte[] DUTResp = new byte[0];
            int inihsa = globalpar.hsa;
            int inihbp = globalpar.hbp;
            int inihfp = globalpar.hfp;
            float[] cmvolt = new float[3] {
                 0.33F, 0.2F ,0.07F
            };
            float[] difvolt = new float[5] {
               0.1F, 0.28F, 0.22F, 0.16F , 0.14F
            };
            

            do
            {
                if (backgroundWorker1.CancellationPending == true)
                {

                    e.Cancel = true;
                    break;


                }
                else
                {
                    globalpar.bitrate = ((globalpar.hsa + globalpar.hbp + globalpar.hfp + globalpar.hact) * (globalpar.vsa + globalpar.vbp + globalpar.vfp + globalpar.vact) * globalpar.pixelformat / globalpar.lanecnt * globalpar.fr / 1000000 / 2 + 1);
                    PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, ((float)globalpar.bitrate + 1) * 1000000, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_LP_FREQ, (float)18e+6, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH, globalpar.hfp, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH, globalpar.hbp, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC, globalpar.hsa, ref errMsg, ref statusMsg));
                    float ui = 1F / ((globalpar.bitrate)*2) / 1000000F;
                    System.Threading.Thread.Sleep(1000);
                     if (globalpar.pixelformat == 24)
                    {
                        for (int i = 0; i < 3; i++) // CM volt
                        {
                            for (int j = 0; j < 5; j++) //diff volt
                            {
                                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.ENABLE_AUTO_SET_CLOCK_DELAY, 0, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, (cmvolt[i] - difvolt[j] * 2), ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, (cmvolt[i] + difvolt[j] * 2), ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));

                                for (float k = 1; k <= 19; k++)
                                {
                                    float skew = ui / 20 * k;
                                    PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.SET_HS_DELAY, 4, skew, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                   
                                    PE(client.MIPICmd(RPCDefs.PACKED_PIXEL_STREAM_888, 0, false, RPCDefs.DT_HS, 0, 1, 0, 0, textbox_videopicpath.Text, null, ref errMsg, ref statusMsg));
                                    PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
                                    System.Threading.Thread.Sleep(globalpar.waittime);


                                    PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.SAVE_DUT_RESPONSE, textboxrpcsave.Text, 100, globalpar.pixelformat + "bit , " + globalpar.videotype +" , " +(globalpar.bitrate) * 2 + " Mbps " + ", CM=" + cmvolt[i] + " mV , Diff = " + difvolt[j] + ", UI = " + (float)1/20*k +" , Delay time " + skew*1E12F +measfluke(), 0, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.PG_ABORT, ref errMsg, ref statusMsg));
                                }
                            }
                        }




                        
                    }
                    else if (globalpar.pixelformat == 18)
                    {
                        for (int i = 0; i < 3; i++) // CM volt
                        {
                            for (int j = 0; j < 5; j++) //diff volt
                            {
                                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.ENABLE_AUTO_SET_CLOCK_DELAY, 0, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, (cmvolt[i] - difvolt[j] * 2), ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, (cmvolt[i] + difvolt[j] * 2), ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));

                                for (float k = 1; k <= 19; k++)
                                {
                                    float skew = ui / 20 * k;
                                    PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.SET_HS_DELAY, 4, skew, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                    
                                    PE(client.MIPICmd(RPCDefs.PACKED_PIXEL_STREAM_666, 0, false, RPCDefs.DT_HS, 0, 1, 0, 0, textbox_videopicpath.Text, null, ref errMsg, ref statusMsg));
                                    PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
                                    System.Threading.Thread.Sleep(globalpar.waittime);


                                    PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.SAVE_DUT_RESPONSE, textboxrpcsave.Text, 100, globalpar.pixelformat + "bit , " + globalpar.videotype + " , " + (globalpar.bitrate) * 2 + " Mbps , " + ", CM=" + cmvolt[i] + " mV , Diff = " + difvolt[j] + ", UI = " + (float)1 / 20 * k + measfluke(), 0, ref errMsg, ref statusMsg));
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++) // CM volt
                        {
                            for (int j = 0; j < 5; j++) //diff volt
                            {
                                PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.ENABLE_AUTO_SET_CLOCK_DELAY, 0, ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_HS_LOW_VOLT, 1, (cmvolt[i] - difvolt[j] * 2), ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.SET_HS_HIGH_VOLT, 1, (cmvolt[i] + difvolt[j] * 2), ref errMsg, ref statusMsg));
                                PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));

                                for (float k = 1; k <= 19; k++)
                                {
                                    float skew = ui / 20 * k;
                                    PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.SET_HS_DELAY, 4, skew, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                                    
                                    PE(client.MIPICmd(RPCDefs.PACKED_PIXEL_STREAM_565, 0, false, RPCDefs.DT_HS, 0, 1, 0, 0, textbox_videopicpath.Text, null, ref errMsg, ref statusMsg));
                                    PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
                                    System.Threading.Thread.Sleep(globalpar.waittime);


                                    PE(client.MIPICmd(RPCDefs.BTA, 0, false, RPCDefs.DT_LP, 0, 0, 0, 0, "", null, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteQuery(RPCCmds.GET_DUT_RESPONSE, 0, ref DUTResp, ref errMsg, ref statusMsg));
                                    PE(client.PGRemoteCmd(RPCCmds.SAVE_DUT_RESPONSE, textboxrpcsave.Text, 100, globalpar.pixelformat + "bit , " + globalpar.videotype + " , " + (globalpar.bitrate) * 2 + " Mbps , " + ", CM=" + cmvolt[i] + " mV , Diff = " + difvolt[j] + ", UI = " + (float)1 / 20 * k + measfluke(), 0, ref errMsg, ref statusMsg));
                                }
                            }
                        }
                        
                    }


                     backgroundskewswing.ReportProgress(0);

                    if (checkBox_webcam.Checked == true)
                    {
                        cap = new Capture(0);
                        Image<Bgr, Byte> camimage = cap.QueryFrame();
                        //because we are using an autosize picturebox we need to do a thread safe update
                        DisplayImage(camimage.ToBitmap());
                        cap.Dispose();
                        string savepath = Path.GetDirectoryName(opendutpath.FileName);
                        pictureBox1.Image.Save(@savepath +"\\" + globalpar.pixelformat + "bit" + globalpar.videotype + (Convert.ToInt32(textbox_hsfreq.Text) * 2).ToString() + "Mbps.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    }

                    else
                    {

                    }

                    PE(client.PGRemoteCmd(RPCCmds.PG_ABORT, ref errMsg, ref statusMsg));
                    switch (globalpar.testnum)
                    {
                        case 0:
                            globalpar.hsa = globalpar.hsa + 30;
                            globalpar.testnum = 1;
                            break;
                        case 1:
                            globalpar.hbp = globalpar.hbp + 30;
                            globalpar.testnum = 2;
                            break;
                        case 2:
                            globalpar.hfp = globalpar.hfp + 30;
                            globalpar.testnum = 0;
                            break;

                    }
                    /*
                    globalpar.bitrate = ((globalpar.hsa + globalpar.hbp + globalpar.hfp + globalpar.hact) * (globalpar.vsa + globalpar.vbp + globalpar.vfp + globalpar.vact) * globalpar.pixelformat / globalpar.lanecnt * globalpar.fr / 1000000 / 2 + 1);
                    PE(client.PGRemoteCmd(RPCCmds.START_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_HS_FREQ, ((float)globalpar.bitrate + 1) * 1000000, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_LP_FREQ, (float)18e+6, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.END_EDIT_CONFIG, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HFPORCH, globalpar.hfp, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HBPORCH, globalpar.hbp, ref errMsg, ref statusMsg));
                    PE(client.PGRemoteCmd(RPCCmds.SET_TIMING_HSYNC, globalpar.hsa, ref errMsg, ref statusMsg));
                    //sw.WriteLine(globalpar.hsa + " " + globalpar.hbp + " " + globalpar.hfp + " " + globalpar.bitrate);
                     */
                }

            } while (globalpar.bitrate < globalpar.targetbitrate);

            //sw.Close();
        }

        private void backgroundskewswing_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            textboxhfp.Text = globalpar.hfp.ToString();
            textboxhbp.Text = globalpar.hbp.ToString();
            textboxhsa.Text = globalpar.hsa.ToString();
            textbox_hsfreq.Text = globalpar.bitrate.ToString();
        }

        private void backgroundskewswing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                textbox_fortest.Text = "some error";
            else if (e.Cancelled)
                textbox_fortest.Text = "canelled";
            else
                hwreset();
            for (int i = 0; i < 6; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    textboxhsa.Text = globalpar.inihsa.ToString();
                    textboxhbp.Text = globalpar.inihbp.ToString();
                    textboxhfp.Text = globalpar.inihfp.ToString();
                    btn_openautotest.PerformClick();
                    return;
                }
            }
            for (int k = 0; k < 3; k++)
            {
                if (checkedListBox2.GetItemChecked(k))
                {
                    checkedListBox2.SetItemChecked(k, false);
                    callbackvideoset();
                    textboxhsa.Text = globalpar.inihsa.ToString();
                    textboxhbp.Text = globalpar.inihbp.ToString();
                    textboxhfp.Text = globalpar.inihfp.ToString();
                    btn_openautotest.PerformClick();
                    goto finish;
                }
                else
                    textbox_fortest.Text = "All done";
            }


        finish: textbox_fortest.Text = "no error";
            globalpar.videorunning = false;
        }





    }
}