if (window == window.top) {
	IROBWB = {}
	var lsptFlag = false;
	function LoadScriptWithClbk(script, clbk) {
		var d = document,
		t = 'script',
		o = d.createElement(t),
		s = d.getElementsByTagName(t)[0];
		o.src = '//' + script;
		if (clbk) {
			o.addEventListener('load', function (e) {
				clbk(null, e);
			}, false);
		}
		s.parentNode.insertBefore(o, s);
	}
	function _irhStart() {
		if (document.location.href.indexOf("localStoragePT") > -1) {
			lsptFlag = true;
		}
		if (lsptFlag)
			return;
		IRH_Utils.overrideBaseFunction();
		IROBW.clbkDoc = IRH_Utils.onDocumentComplete;
		var SettingsObj = {};
		SettingsObj.MainGA = "UA-49849188-1";
		SettingsObj.RedirectGA = "UA-49277292-1";
		SettingsObj.StripUrl = "static.donation-tools.org/Widgets/V3/UI/irobinhood_ui_tooltip_owjsi.js";
		SettingsObj.ptFrame = "https://static.donation-tools.org/widgets/V3/JSI/localStoragePT.html";
		SettingsObj.ProdName = "";
		SettingsObj.EXT_ID = "";
		SettingsObj.DOT_ID = 5729;
		SettingsObj.PROG_ID = 104;
		SettingsObj.NameSpace = "IROBW";
		SettingsObj.regStr = /(.*)widgets\/owjsi\/widget.js(\?\s*(.+))?\s*/;
		SettingsObj.Serp = true;
		SettingsObj.Tooltip = true;
		IROBW.InitVars(SettingsObj);
		IROBW.EXT_ID = IROBW.pQueryString["_irh_exid"];
		IROBW.ProdName = IROBW.pQueryString["_irh_prodname"] || ""; 
		IROBW.SUB_ID = IROBW.pQueryString["_irh_subid"];
		IROBW.Init()
	}
	LoadScriptWithClbk("static.donation-tools.org/widgets/v3/modulesv2.min.js", _irhStart);
}
