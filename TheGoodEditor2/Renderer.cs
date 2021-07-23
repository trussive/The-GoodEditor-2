using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Windows;
using SharpDX.Direct3D;
using D3D11 = SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace TheGoodEditor2 
{
    public class Renderer 
    {
        private RenderForm rForm;

        public int scrX = 800;
        public int scrY = 600;

        private D3D11.Device dev;
        private D3D11.DeviceContext devContext;
        private D3D11.RenderTargetView renderTargetView;
        private SwapChain swapChain;

        public Renderer()
        {
            rForm = new RenderForm("The GoodEditor 2 Render Window");
            rForm.ClientSize = new System.Drawing.Size(scrX, scrY);
            rForm.AllowUserResizing = true;
        }

        public void Init()
        {
            ModeDescription backBufferDesc = new ModeDescription(scrX, scrY, new Rational(60, 1), Format.R8G8B8A8_UNorm);

            SwapChainDescription swapChainDesc = new SwapChainDescription()
            {
                ModeDescription = backBufferDesc,
                SampleDescription = new SampleDescription(1, 0),
                Usage = Usage.RenderTargetOutput,
                BufferCount = 1,
                OutputHandle = rForm.Handle,
                IsWindowed = true
            };

            D3D11.Device.CreateWithSwapChain(DriverType.Hardware, D3D11.DeviceCreationFlags.None, swapChainDesc, out dev, out swapChain);
            devContext = dev.ImmediateContext;

            D3D11.Texture2D backBuffer = swapChain.GetBackBuffer<D3D11.Texture2D>(0);

            renderTargetView = new D3D11.RenderTargetView(dev, backBuffer);


        }

        public void Update()
        {
            RenderLoop.Run(rForm, rCallback);
        }

        public void Render()
        {
            
        }

        private void rCallback()
        {
            Render();
        }
    }
}
