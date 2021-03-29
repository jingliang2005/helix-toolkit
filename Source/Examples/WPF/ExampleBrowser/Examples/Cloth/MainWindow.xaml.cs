// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Helix Toolkit">
//   Copyright (c) 2014 Helix Toolkit contributors
// </copyright>
// <summary>
//   Interaction logic for MainWindow.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

/// <summary>
/// 布演示。
/// </summary>
namespace ClothDemo
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Media3D;

    using ExampleBrowser;

    /// <summary>
    /// 主窗口的交互逻辑
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [Example(null, "模拟布料物理。Simulates cloth physics.")]
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 旗帜模型（几何模型3D)。
        /// </summary>
        public GeometryModel3D FlagModel { get; set; }
        /// <summary>
        /// 旗帜。
        /// </summary>
        public Flag Flag { get; private set; }
        /// <summary>
        /// 计时器。
        /// </summary>
        private readonly Stopwatch watch;
        /// <summary>
        /// 积分器线程.
        /// </summary>
        private readonly Thread integratorThread;

        /// <summary>
        /// 初始化，创建旗帜，启动积分器线程，绑定窗口加载，窗口关闭，合成器渲染事件。
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            CreateFlag();

            DataContext = this;
            Loaded += MainWindow_Loaded;

            watch = new Stopwatch();
            watch.Start();
            integratorThread = new Thread(IntegrationWorker);
            integratorThread.Start();

            // 合成目标渲染
            CompositionTarget.Rendering += this.OnCompositionTargetRendering;
            this.Closing += MainWindow_Closing;
        }

        /// <summary>
        /// 主窗口关闭。终止积分器线程。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            integratorThread.Abort();
        }

        /// <summary>
        /// 积分器工作，根据计时器值更新旗帜。
        /// </summary>
        private void IntegrationWorker()
        {
            while (true)
            {
                double dt = 1.0 * watch.ElapsedTicks / Stopwatch.Frequency;
                watch.Restart();
                Flag.Update(dt);
            }
        }

        /// <summary>
        /// 合成目标渲染，旗帜移动。（变换）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompositionTargetRendering(object sender, EventArgs e)
        {
            Flag.Transfer();
        }

        /// <summary>
        /// 主窗体加载。view1(HelixViewport3D)根据屏幕范围（大小）缩放。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            view1.ZoomExtents();
        }

        /// <summary>
        /// 创建旗帜，旗帜模型。从png图片创建旗帜，然后用旗帜创建旗帜模型。
        /// </summary>
        private void CreateFlag()
        {
            Flag = new Flag("Examples/Cloth/FlagOfNorway.png");
            Flag.Init();

            FlagModel = new GeometryModel3D
                            {
                                Geometry = Flag.Mesh,
                                Material = Flag.Material,
                                BackMaterial = Flag.Material
                            };
        }
    }
}