/*
 * Created by Ranorex
 * User: jwilbur
 * Date: 8/23/2016
 * Time: 12:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace chessBot.Loop
{
    /// <summary>
    /// Description of LogicFlow.
    /// </summary>
    [TestModule("741AD188-DA9C-4919-ACCC-A9EAB61F865B", ModuleType.UserCode, 1)]
    public class LogicFlow : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LogicFlow()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
