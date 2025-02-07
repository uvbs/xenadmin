﻿/* Copyright (c) Cloud Software Group, Inc. 
 * 
 * Redistribution and use in source and binary forms, 
 * with or without modification, are permitted provided 
 * that the following conditions are met: 
 * 
 * *   Redistributions of source code must retain the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer. 
 * *   Redistributions in binary form must reproduce the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer in the documentation and/or other 
 *     materials provided with the distribution. 
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
 * CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
 * INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
 * MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR 
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, 
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR 
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE 
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
 * SUCH DAMAGE.
 */

using System.Drawing;
using System.Linq;
using XenAdmin.Core;
using XenAdmin.Wizards.PatchingWizard;
using XenAPI;


namespace XenAdmin.Commands
{
    /// <summary>
    /// Shows the patching wizard.
    /// </summary>
    internal class InstallNewUpdateCommand : Command
    {
        /// <summary>
        /// Initializes a new instance of this Command. The parameter-less constructor is required if 
        /// this Command is to be attached to a ToolStrip menu item or button. It should not be used in any other scenario.
        /// </summary>
        public InstallNewUpdateCommand()
        {
        }

        public InstallNewUpdateCommand(IMainWindow mainWindow)
            : base(mainWindow)
        {
        }

        protected override void RunCore(SelectedItemCollection selection)
        {
            MainWindowCommandInterface.ShowForm(typeof(PatchingWizard));
        }

        protected override bool CanRunCore(SelectedItemCollection selection)
        {
            return ConnectionsManager.XenConnectionsCopy.Any(c => c.IsConnected && Helpers.Post82X(c));
        }

        protected override string GetCantRunReasonCore(IXenObject item)
        {
            var connected = ConnectionsManager.XenConnectionsCopy.Where(c => c.IsConnected).ToList();

            if (connected.Count > 0 && connected.All(c => !Helpers.Post82X(c)))
                return string.Format(Messages.INSTALL_PENDING_UPDATES_DISABLED_REASON,
                    BrandManager.BrandConsole, Program.VersionText, BrandManager.ProductVersion821);

            return base.GetCantRunReasonCore(item);
        }

        public override Image ContextMenuImage => Images.StaticImages._000_HostUnpatched_h32bit_16;

        public override string ContextMenuText => Messages.INSTALL_PENDING_UPDATES;
    }
}
