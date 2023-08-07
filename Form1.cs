using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinForm_Demo
{
    public partial class Form1 : Form
    {
        string str_html;

        public Form1()
        {
            InitializeComponent();

            string path = (System.Environment.CurrentDirectory).Replace(@"\", @"/"); //html 图片路径
            str_html =
                @"
                    <!DOCTYPE html>
                    <html>
                    <head>
                        <meta charset='UTF-8'>
	                    <meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1'> 
	                    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                    <style type='text/css'>
                        { margin: 0; padding: 0; border: 0; }
                            html,body{ margin: 0; }
	                    @-webkit-keyframes STAR-MOVE {
				            from { background-position:0% 0% }
				            to { background-position: 600% 0% }
			            }
			            @keyframes STAR-MOVE {
				            from { background-position: 0% 0% }
				            to { background-position: 600% 0% }
			            }
			            .wall { position: absolute; top: 0; left: 0; bottom: 0; right: 0; }
			            div#background{
				            background: black url('" + path + @"/Res/background.png') repeat-x 5% 0%;
				            background-size: cover;
				            -webkit-animation: STAR-MOVE  200s linear infinite;
				            -moz-animation: STAR-MOVE  200s linear infinite;
				            -ms-animation: STAR-MOVE  200s linear infinite;
				            animation: STAR-MOVE  200s linear infinite;
			            }
			            div#midground{
				            background:url('" + path + @"/Res/midground.png')repeat 20% 0%;
				            z-index: 1;
				            -webkit-animation: STAR-MOVE  100s linear infinite;
				            -moz-animation: STAR-MOVE  100s linear infinite;
				            -ms-animation: STAR-MOVE  100s linear infinite;
				            animation: STAR-MOVE  100s linear infinite;
			            }
			            div#foreground{
				            background:url('" + path + @"/Res/foreground.png')repeat 35% 0%;
				            z-index: 2;
				            -webkit-animation: STAR-MOVE  50s linear infinite;
				            -moz-animation: STAR-MOVE  50s linear infinite;
				            -ms-animation: STAR-MOVE  50s linear infinite;
				            animation: STAR-MOVE  50s linear infinite;
			            }
                        #mdiv{
                            position: absolute; border: 0px solid #ddd; top: 60px; left: 50px; background-color: #fefefe; width:429px;height:108px;visibility: visible; padding: 5px; 
                            overflow: hidden;background: rgba(255,255,255, 0);
                        }
                    </style>
                </head>
                <body>
                    <div id='background' class='wall'></div>
                    <div id='midground' class='wall'></div>
                    <div id='foreground' class='wall'></div>
                    <div id='mdiv'><img src='" + path + @"/Res/log.png'></div>
                </body>
            </html>";

            //UiButtonMethod.transparencyButton tr = new UiButtonMethod.transparencyButton();
            //tr.transparencyBtn(this, (Bitmap)Image.FromFile(@"res\m1.png"), new Point(350, 164), new Size(60, 60), 155, 255, null);
        }





        AlphaForm Ifm, Vfm; //窗体
        int _form = 1; //当前窗体标识
        AlphaForm.Animations _formAnimation = 窗体动画.窗体水平翻转; //窗体动画方式

        //选择动画方式
        private void checkBox1_Click(object sender, EventArgs e)
        {
            CheckBox ck = (CheckBox)sender;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            ck.Checked = true;
            if (int.Parse(ck.Tag.ToString()) == 1) _formAnimation = 窗体动画.窗体水平翻转;
            if (int.Parse(ck.Tag.ToString()) == 2)  _formAnimation = 窗体动画.窗体淡入;
            if (int.Parse(ck.Tag.ToString()) == 3) _formAnimation = 窗体动画.窗体旋转;
            if (int.Parse(ck.Tag.ToString()) == 4) _formAnimation = 窗体动画.窗体自上而下;
            if (int.Parse(ck.Tag.ToString()) == 5) _formAnimation = 0;
        }

        int pt1 = 窗体切换.翻转切换, pt2 = 窗体切换.翻转切换;
        private void checkBox6_Click(object sender, EventArgs e)
        {
            CheckBox ck = (CheckBox)sender;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            ck.Checked = true;
            if (int.Parse(ck.Tag.ToString()) == 1 )  { pt1 = 窗体切换.旋转切换; pt2 = 窗体切换.旋转切换; }
            if (int.Parse(ck.Tag.ToString()) == 2 )  { pt1 = 窗体切换.翻转切换; pt2 = 窗体切换.翻转切换; }
            if (int.Parse(ck.Tag.ToString()) == 3 )  { pt1 = 窗体切换.顶底切换; pt2 = 窗体切换.顶底切换; }
            if (int.Parse(ck.Tag.ToString()) == 4 )  { pt1 = 窗体切换.底顶切换; pt2 = 窗体切换.底顶切换; }
            if (int.Parse(ck.Tag.ToString()) == 5 )  { pt1 = 窗体切换.左右切换; pt2 = 窗体切换.左右切换; }
            if (int.Parse(ck.Tag.ToString()) == 6 )  { pt1 = 窗体切换.右左切换; pt2 = 窗体切换.右左切换; }
            if (int.Parse(ck.Tag.ToString()) == 7 )  { pt1 = 窗体切换.翻转切换; pt2 = 窗体切换.旋转切换; }
            if (int.Parse(ck.Tag.ToString()) == 8 )  { pt1 = 窗体切换.左右切换; pt2 = 窗体切换.右左切换; }
            if (int.Parse(ck.Tag.ToString()) == 9 )  { pt1 = 窗体切换.顶底切换; pt2 = 窗体切换.底顶切换; }
            if (int.Parse(ck.Tag.ToString()) == 10) { pt1 = 窗体切换.顶底切换; pt2 = 窗体切换.翻转切换; }
        }


        putAlphaForm putForm;

        PictureBox pb2;
        //Panel pb2;

        //TransparentPanel pb2;

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * 将窗体记录到list里面，可以选择显示第几个窗体（show显示或visable=false不显示），
             * 鼠标事件表示切换到那个窗体 putForm._putForm(0, 1, 切换速度); 表示0切换到1，
             * 如有多个窗体可 putForm._putForm(1, 3, 切换速度);等等
            */
            try { Ifm.Close(); } catch { }
            try { Vfm.Close(); } catch { }

            //先显示 第二个窗体（Vfm），第一个不显示（Ifm）

            putForm = new putAlphaForm(); //窗体切换类
            putForm._putFormBegin(400,400,551,500,1); //切换前定义：位置x、位置y、宽度、高度、透明度
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Ifm = new AlphaForm(); //定义一个新窗体
            Ifm.ShowInTaskbar = false;
            Ifm.ShowIcon = false;
            Ifm.FormBorderStyle = FormBorderStyle.None;
            Ifm.StartPosition = FormStartPosition.Manual;
            Ifm.Location = new Point(putForm.form_x, putForm.form_y); //窗体位置
            Ifm.Size = new Size( putForm.form_width, putForm.form_height ); //窗体大小
            Ifm.Opacity = 0;//窗体透明度
            Ifm.窗体图像 = new CutPixelAlphaImage().CutAlphaFormImage(窗体样式.样式1, Ifm.Size.Width, Ifm.Size.Height);

            WebBrowser webBack = new WebBrowser();
            webBack.Size = new Size(522, 208);
            webBack.Location = new Point(15, 13);
            //禁用右键菜单
            webBack.IsWebBrowserContextMenuEnabled = false;
            //禁用键盘快捷键
            webBack.WebBrowserShortcutsEnabled = false;
            webBack.DocumentText = str_html;
            Ifm.Controls.Add(webBack);

            TextBox tb = new TextBox();
            tb.Font = new Font("微软雅黑", 10.5F, FontStyle.Regular);
            tb.Location = new Point(150, 254);
            tb.Width = 188;
            //tb.BorderStyle = BorderStyle.None;
            tb.Text = "可以输入文字...";
            Ifm.Controls.Add(tb);

            PictureBox btn1 = new PictureBox(); //窗体放一个组件，注意先后顺序，最上面显示的放第一个，否则会遮盖住
            btn1.Size = new Size(106, 29);
            btn1.Cursor = Cursors.Hand;
            btn1.Location = new Point(200, 330);
            btn1.Image = Image.FromFile("btn1.png");
            btn1.BackColor = Color.Transparent;
            btn1.Click += new EventHandler(b1_Click); //组件鼠标事件
            Ifm.Controls.Add(btn1); //组件添加到窗体
            Ifm.Show(); //显示窗体 由于是第一个窗体，显示。可以设定不显示，下面的显示
            putForm._getPutFormInfo(Ifm); //记录窗体信息

            Ifm.Visible = false;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Vfm = new AlphaForm();//定义一个新窗体
            Vfm.ShowInTaskbar = false;
            Vfm.ShowIcon = false;
            Vfm.FormBorderStyle = FormBorderStyle.None;
            Vfm.StartPosition = FormStartPosition.Manual;
            Vfm.Location = new Point(putForm.form_x, putForm.form_y); //窗体位置
            Vfm.Size = new Size(putForm.form_width, putForm.form_height); //窗体大小
            Vfm.Opacity = 1;//窗体透明度 这里为不显示
            Vfm.窗体图像 = new CutPixelAlphaImage().CutAlphaFormImage(窗体样式.样式1, Vfm.Size.Width, Vfm.Size.Height);
            Vfm.AnimationSpeed = 5; //动画速度，根据需要调节
            Vfm.Animation = _formAnimation;

            PictureBox btn2 = new PictureBox();
            btn2.Size = new Size(106, 29);
            btn2.Cursor = Cursors.Hand;
            btn2.Location = new Point(50, 20);
            btn2.Image = Image.FromFile("btn2.png");
            btn2.Click += new EventHandler(b2_Click);
            Vfm.Controls.Add(btn2);

            
            pb2 = new UiControlsMethod.PictureBoxEx();
            pb2.Size = new Size(522, 370);
            pb2.Location = new Point(15, 13);
            pb2.Image = Image.FromFile("b1.png");
            
            Vfm.Controls.Add(pb2);

            /*
             //上个例子写过了，这里就注销掉了
            //透明遮挡层//////////////////////////////////////////////////////////////////////
            UiTransparentRectMethod dt = new UiTransparentRectMethod(); //建立一个遮挡层
            dt.BackColor = Color.SteelBlue; //颜色
            dt.Radius = 10; //圆角 角度
            dt.ShapeBorderStyle = UiTransparentRectMethod.ShapeBorderStyles.ShapeBSNone; //边框
            dt.Size = new Size(450, 320); //大小
            dt.Location = new Point(30, 35); //位置
            dt.Opacity = 110; //透明度
            pb2.Controls.Add(dt); //添加到背景图片上
            */


            //更换背景色按钮
            //discolorBtn(属于哪个控件, 位置, 大小, 图像, 响应的背景色, 透明度, 点击事件); 点击事件可为 null
            UiButtonMethod.discolorButton tr = new UiButtonMethod.discolorButton();
            tr.discolorBtn(pb2,new Point(50,40),new Size(60,60),(Bitmap)Image.FromFile(@"res\mt3.png"),Color.Red,150,b2_Click);

            //更换图像按钮
            //toggleBtn(属于哪个控件, 初始图像, 更换图像, 位置, 大小, 更换图像的背景色, 更换图像的背景透明度, 点击事件); 点击事件可为 null
            UiButtonMethod.toggleButton to = new UiButtonMethod.toggleButton();
            to.toggleBtn(pb2,(Bitmap)Image.FromFile(@"res\mt1.png"),(Bitmap)Image.FromFile(@"res\mt2.png"),new Point(50,120),new Size(60,60),Color.White,100,b2_Click);

            //将按钮添加到透明遮挡层
            //新建3个 缩放按钮，zb.zoomBtn(属于哪个控件内, 图像文件, 显示位置, 初始大小, 缩放大小, 点击事件); 点击事件可为 null
            //必须建立在有背景图像的组件之内，不能直接建立在窗体，否则穿透到窗体背景了，如无透明背景四方体，可直接显示到窗体
            //这里鼠标事件直接执行的是 private void b2_Click(object sender, EventArgs e)
            //缩放按钮
            for (int i = 0; i < 4; i++)
            {
                UiButtonMethod.zoomButton zbtn = new UiButtonMethod.zoomButton();
                zbtn.zoomBtn(pb2, new Bitmap(@"res\n" + (i + 1) + ".png"), new Point(50 + i * 85, 250), new Size(65, 65), new Size(88, 88), b2_Click);
            }
            Vfm.Show();


            btn2.Focus();
            putForm._getPutFormInfo(Vfm);//记录窗体信息
            Vfm.Visible = true; //第二个窗体，设置为不显示，可以和上面的互换
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void b1_Click(object sender, EventArgs e)
        {
            //第一个窗体的按钮，由1切换到2窗体，pt1为切换方式
            putForm._putForm(0, 1, 13,pt1);
            _form = 1; //当前窗体标识
        }

        private void b2_Click(object sender, EventArgs e)
        {
            //第二个窗体的按钮，由2切换到1窗体，pt2为切换方式
            putForm._putForm(1, 0, 13,pt2);
            _form = 0;//当前窗体标识
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { Ifm.Close(); } catch { }
            try { Vfm.Close(); } catch { }
        }


        
        //抖动
        private void button2_Click(object sender, EventArgs e)
        {
            
            //shakeForm(窗体,范围,次数,速度);
            if ( _form== 0 ) UiControlsMethod.AnimationFormMethods.shakeForm(Ifm,8,20,15);
            if ( _form == 1) UiControlsMethod.AnimationFormMethods.shakeForm(Vfm, 8, 20, 15);
        }


        private void button9_Click(object sender, EventArgs e)
        {
            try { Ifm.Close(); } catch { }
            try { Vfm.Close(); } catch { }
        }

       
    }
}
