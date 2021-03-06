﻿using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using System.Collections.Generic;

namespace VNToolkit.VNEditor.VNUtility {

	public enum VN_PANELSTATE {
		OPEN,
		CLOSE,
		SAVE,
		LOAD,
		CLEAR,
		RESET,
		REFRESH
	}

	public interface VNIPanel {

		// Public Variables
		VNIPanel parent { get; set; }
		List<VNIPanel> children { get; set; }

		// When panel is shown
		bool PanelActive { get; }

		// When panel is currently in use or opened
		bool PanelEnabled { get; }

		VN_PANELSTATE PanelState { get; }

		// When panel is foldable
		//bool IsPanelFoldable { get; }

		string PanelTitle { get; }

		// NOTE: Panel Width set to negative value will make the panel width flexible
		//float PanelWidth { get; }

		string PanelControlName { get; }

		//System.Action<Rect> OnPanelGUI  { get; }

		void OnPanelEnable(UnityAction repaint);

		//void PanelOpen();
		//void PanelClose();
		//void PanelSave();
		//void PanelLoad();
		//void PanelClear();
		//void PanelReset();

		//void OnPanelDraw(Rect position);

		void SetPanelActive(bool active);
		void SetPanelState(VN_PANELSTATE state);

		void AddChildren(VNIPanel child);
		List<VNIPanel> GetChildren();
		VNIPanel GetChild(string title);
	}
}