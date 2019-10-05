using System.Collections.Generic;
using Xenko.Core.Mathematics;
using Xenko.Input;
using Xenko.Engine;

namespace SkeletalFuckery
{
    public class Player : SyncScript
    {
        public int Health = 10;

        public override void Start()
        {

            Input.VirtualButtonConfigSet = Input.VirtualButtonConfigSet ?? new VirtualButtonConfigSet();

            //asd.Insert(0, new VirtualButtonBinding("Horizontal", VirtualButton.Keyboard.))

            VirtualButtonTwoWay horizontal = new VirtualButtonTwoWay(VirtualButton.Keyboard.D, VirtualButton.Keyboard.A);
            VirtualButtonTwoWay vertical = new VirtualButtonTwoWay(VirtualButton.Keyboard.S, VirtualButton.Keyboard.W);

            VirtualButtonBinding bindH = new VirtualButtonBinding("Horizontal", horizontal);
            VirtualButtonBinding bindV = new VirtualButtonBinding("Vertical", vertical);

            VirtualButtonConfig config = new VirtualButtonConfig();

            config.Add(bindH);
            config.Add(bindV);

            Input.VirtualButtonConfigSet.Add(config);
        }

        public override void Update()
        {
            Vector3 input = new Vector3(Input.GetVirtualButton(0, "Horizontal"), 0f, Input.GetVirtualButton(0, "Vertical"));
            Entity.Transform.Position += input * 5f * (float)Game.UpdateTime.Elapsed.TotalSeconds;
        }
    }
}
