﻿// Copyright (c) 2019 OPTIKEY LTD (UK company number 11854839) - All Rights Reserved

namespace JuliusSweetland.OptiKey.Chat.Properties
{

    class Settings : JuliusSweetland.OptiKey.Properties.Settings
    {

        public static void Initialise()
        {
            Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
            InitialiseWithDerivedSettings(defaultInstance);
        }

        /*
         * Override the settings relating to conversation mode, to lock user into
         * conversation mode only.
         */
        #region App-specific settings

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public override bool ConversationOnlyMode
        {
            get
            {
                return true;
            }
            set
            {
                // no-op, can't be changed in this app
            }
        }


        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public override bool MagnifySuppressedForScrollingActions
        {
            get { return false; }
            set { /* no-op */ }
        }


        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public override bool AllowMultipleInstances
        {
            get
            {
                return false;
            }
            set
            {
                // no-op, can't be changed in this app
            }
        }
        #endregion


        #region Unsupported features

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public override bool EnableCommuniKateKeyboardLayout
        {
            get { return false; }
            set { /* no-op */ }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public override bool LookToScrollEnabled
        {
            get { return false; }
            set { /* no-op */ }
        }

        #endregion
    }
}
