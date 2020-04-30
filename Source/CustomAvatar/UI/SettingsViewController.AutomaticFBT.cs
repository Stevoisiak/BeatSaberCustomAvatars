﻿using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Components.Settings;
using UnityEngine.UI;

namespace CustomAvatar.UI
{
    internal partial class SettingsViewController
    {
        #region Components
        #pragma warning disable 649
        #pragma warning disable IDE0044

        [UIComponent("calibrate-fbt-on-start")] private BoolSetting _calibrateFullBodyTrackingOnStart;
        [UIComponent("pelvis-offset")] private IncrementSetting _pelvisOffset;
        [UIComponent("left-foot-offset")] private IncrementSetting _leftFootOffset;
        [UIComponent("right-foot-offset")] private IncrementSetting _rightFootOffset;

        [UIComponent("auto-calibrate-button")] private Button _autoCalibrateButton;
        [UIComponent("auto-clear-button")] private Button _autoClearButton;
        
        #pragma warning restore 649
        #pragma warning restore IDE0044
        #endregion

        #region Actions
        // ReSharper disable UnusedMember.Local

        [UIAction("calibrate-fbt-on-start-change")]
        private void OnCalibrateFullBodyTrackingOnStartChanged(bool value)
        {
            _settings.calibrateFullBodyTrackingOnStart = value;
        }

        [UIAction("pelvis-offset-change")]
        private void OnPelvisOffsetChanged(float value)
        {
            _settings.automaticCalibration.pelvisOffset = value;
        }

        [UIAction("left-foot-offset-change")]
        private void OnLeftFootOffsetChanged(float value)
        {
            _settings.automaticCalibration.leftLegOffset = value;
        }

        [UIAction("right-foot-offset-change")]
        private void OnRightFootOffsetChanged(float value)
        {
            _settings.automaticCalibration.rightLegOffset = value;
        }

        [UIAction("auto-calibrate-fbt-click")]
        private void OnCalibrateAutoFullBodyTrackingClicked()
        {
            _avatarTailor.CalibrateFullBodyTrackingAuto();
            _autoClearButton.interactable = !_settings.automaticCalibration.isDefault;
        }

        [UIAction("auto-clear-fbt-calibration-data-click")]
        private void OnClearAutoFullBodyTrackingCalibrationDataClicked()
        {
            _avatarTailor.ClearAutomaticFullBodyTrackingData();
            _autoClearButton.interactable = false;
        }
        
        // ReSharper restore UnusedMember.Local
        #endregion
    }
}