﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUISpecFlowBootstrap.UIMaps.ContextMenuClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class ContextMenu
    {
        
        #region Properties
        public UIContextMenuWindow UIContextMenuWindow
        {
            get
            {
                if ((this.mUIContextMenuWindow == null))
                {
                    this.mUIContextMenuWindow = new UIContextMenuWindow();
                }
                return this.mUIContextMenuWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIContextMenuWindow mUIContextMenuWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIContextMenuWindow : WinWindow
    {
        
        public UIContextMenuWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Контекст";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32768";
            #endregion
        }
        
        #region Properties
        public UIContextMenu UIContextMenu
        {
            get
            {
                if ((this.mUIContextMenu == null))
                {
                    this.mUIContextMenu = new UIContextMenu(this);
                }
                return this.mUIContextMenu;
            }
        }
        #endregion
        
        #region Fields
        private UIContextMenu mUIContextMenu;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIContextMenu : WinMenu
    {
        
        public UIContextMenu(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "Контекст";
            #endregion
        }
        
        #region Properties
        public WinMenuItem UICopyMenuItem
        {
            get
            {
                if ((this.mUICopyMenuItem == null))
                {
                    this.mUICopyMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUICopyMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Копировать";
                    #endregion
                }
                return this.mUICopyMenuItem;
            }
        }
        
        public WinMenuItem UIPasteMenuItem
        {
            get
            {
                if ((this.mUIPasteMenuItem == null))
                {
                    this.mUIPasteMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIPasteMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Вставить";
                    #endregion
                }
                return this.mUIPasteMenuItem;
            }
        }
        
        public WinMenuItem UIShowLogMenuItem
        {
            get
            {
                if ((this.mUIShowLogMenuItem == null))
                {
                    this.mUIShowLogMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIShowLogMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Показать журнал";
                    #endregion
                }
                return this.mUIShowLogMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUICopyMenuItem;
        
        private WinMenuItem mUIPasteMenuItem;
        
        private WinMenuItem mUIShowLogMenuItem;
        #endregion
    }
}
