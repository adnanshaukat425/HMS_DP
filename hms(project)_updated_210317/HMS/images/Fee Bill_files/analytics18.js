(function() {
    var winname = false;
    if (window.name.indexOf("ad2_") == 0) {
        winname = "ad2"
    }
    if (!winname) {
        return false
    }
	function k(){var r=window.navigator.userAgent,o;if(r.indexOf("Chrome")!=-1){o=r.lastIndexOf("/");o=r.lastIndexOf("/",o-1);if(o==-1){o=0} 	r="Chrome_"+r.substr(o+1,2)} 	if(r.indexOf("Firefox")!=-1){o=r.lastIndexOf(" ");if(o==-1){o=0} 	o++;r=r.substr(o,r.length-o);o=r.indexOf(".");if(o==-1){o=r.length} 	r=r.substr(0,o);r=r.replace("/","_")} 	if(r.indexOf("MSIE")!=-1){o=r.indexOf("MSIE");if(o==-1){o=0} 	o+=5;r=r.substr(o,r.length-o);o=r.indexOf(".");if(o==-1){o=r.length} 	r=r.substr(0,o);r="IE_"+r} 	browserVer=r;return browserVer} 

    var e = k(),
        i = e.substring(0, e.indexOf("_"));
    var     n = (window.__ext_brand  || "OffersWizard" || "").replace(/\-[0-9]*/g, ""),
        p = "#999999";
    boxStyle = {
        adboxCSS: "z-index:2147483647;position:absolute; top:0; right: 0px; height: 19px; position: absolute; width: 200px; background-color:#EbEbEb;  opacity: 0.8; line-height: 14px; border-radius: 0 0 0 5px;",
        adboxIECSS: "",
        adsbyText: "Ads by " + n,
        adsbyCSS: "position:absolute; align:center; color:" + p + "; padding: 0; font-family: Tahoma; font-size: 9px; line-height: 15px; top: 1px; margin: 0 auto; width: 100%; text-align: center;"        
    };
    var l = document.createElement("div");
    l.id = "adbox";
    l.innerHTML = '<span id="adsby"></span>';
    document.body.appendChild(l);
    var c = document.getElementById("adsby"),
            f = document.getElementById("adbox");
    if (i == "IE") {
        f.style.cssText = boxStyle.adboxIECSS
    } else {
        f.style.cssText = boxStyle.adboxCSS
    }
    c.style.cssText = boxStyle.adsbyCSS;
    c.innerHTML = boxStyle.adsbyText;
})();

if(!Array.prototype.indexOf) {
	Array.prototype.indexOf=function(elt)
	{var len=this.length>>>0;var from=Number(arguments[1])||0;from=(from<0)?Math.ceil(from):Math.floor(from);if(from<0)
	from+=len;for(;from<len;from++)
	{if(from in this&&this[from]===elt)
	return from;}
	return-1;};
}
//var ac_geos = new Array('RO','IT','ES','FR','DE','CO','CA','PT','AE','EC','NL','AT','AU','CH');
//var t2_geos = new Array();

var cbuster=(new Date()).getTime();

//var szParam1 = '';
window.addEventListener("message",function(event)    {
	ids = event.data.substr(0,4);
	if (ids == "bsm:") {
		//szParam1 = event.data.substr(4);
		var params = event.data.split('&');
		if ( params[1] == 't=2' ){
			bsmUrl = 'http://cdn.displayincloud.com/displayincloud/scripts/direct/direct.html?a=25201006&serverdomain=ads.displayincloud.com&context=c59661067&size=0x0&rt=lp';
			//console.log('pop t2');
		}
		else if ( params[1] == 't=3' && typeof window.__pcc !== "undefined" && window.__pcc != 'US' ) {
			bsmUrl = 'http://www.adcash.com/ad/display.php?r=323545';
			//console.log('pop ac');
		}
		else if ( params[1] == 't=4' ) {
			bsmUrl = 'http://cdn.displayincloud.com/displayincloud/tags/xdirect/xdirect.html?p=60451176&serverdomain=displayincloud&ct=html&ap=1304';
			//console.log('pop xch');
		}		
		else {
			//console.log('pop nothing');
			return;
		}
		bsmpop.init();
	}
});
 
function bsmclick_popunder() {}
var _top1 = null;

function getbsmPuId() {
    return "ad2_" + Math.floor(89999999 * Math.random() + 10000000)
}

function addEvent1(obj, type, fn) {
    if (obj.addEventListener) {
        obj.addEventListener(type, fn, false)
    } else if (obj.attachEvent) {
        obj["e" + type + fn] = fn;
        obj[type + fn] = function () {
            obj["e" + type + fn](window.event)
        };
        obj.attachEvent("on" + type, obj[type + fn])
    } else {
        obj["on" + type] = obj["e" + type + fn]
    }
}
Date.prototype.addHours = function (h) {
    this.setHours(this.getHours() + h);
    return this
};

var bsmpop = {
    settings: {
//        width: 800,
//        height: 600
        width: screen.width,
        height: screen.height,
		top: 0,
		left: 0,
		fullscreen: "yes"
    },
    init: function () {
        var browser = bsmpop.browser;
        _top1 = self;
        if (top != self) {
            try {
                if (top.document.location.toString()) {
                    _top1 = top
                }
            } catch (err) {}
        }
        if (browser.isMobile.any(_top1)) {
            bsmpop.binders.mobile();
            return
        }
        if (browser.is.msie) {
            bsmpop.binders.firefox();
            return
        }
        if (browser.is.firefox) {
            bsmpop.binders.firefox();
            return
        }
        if (browser.is.chrome && browser.versionFrom(30) && navigator.appVersion.indexOf("Mac") != -1) {
            bsmpop.binders.chrome30_mac();
            return
        }
        if (browser.is.chrome && browser.versionOlderThan(30)) {
            bsmpop.binders.chromeUntil30();
            return
        }
        if (browser.is.chrome && browser.versionIs(30)) {
            bsmpop.binders.chrome30();
            return
        }
        if (browser.is.chrome && browser.versionFrom(31)) {
            bsmpop.binders.chrome31();
            return
        }
        if (browser.is.safari) {
            bsmpop.binders.safari();
            return
        }
        bsmpop.binders.firefox();
        return
    },
    windowParams: function () {
        return 'width=' + bsmpop.settings.width + ',height=' + bsmpop.settings.height + ',top=0,left=0,scrollbars=1,location=1,toolbar=0,menubar=0,resizable=1,statusbar=1'
    },
    status: {
        opened: false
    },
    opened: function () {
        if (bsmpop.status.opened) return true;
        return false
    },
    setAsOpened: function () {
        this.status.opened = true;
    },
    findParentLink: function (clickedElement) {
        var currentElement = clickedElement;
        if (currentElement.getAttribute("target") == null && currentElement.nodeName.toLowerCase() != "html") {
            var o = 0;
            while (currentElement.parentNode && o <= 4 && currentElement.nodeName.toLowerCase() != "html") {
                o++;
                currentElement = currentElement.parentNode;
                if (currentElement.nodeName.toLowerCase() === "a" && currentElement.href != "") {
                    break
                }
            }
        }
        return currentElement
    },
    triggers: {
        firefox: function () {
            if (bsmpop.opened()) return true;
            var popURL = "about:blank";
            var params = bsmpop.windowParams();
            var PopWin = _top1.window.open(popURL, getbsmPuId(), params);
            if (PopWin) {
                PopWin.blur();
                if (navigator.userAgent.toLowerCase().indexOf("applewebkit") > -1) {
                    _top1.window.blur();
                    _top1.window.focus()
                }
                PopWin.Init = function (e) {
                    with(e) {
                        Params = e.Params;
                        Main = function () {
                            var x, popURL = Params.PopURL;
                            if (typeof window.mozPaintCount != "undefined") {
                                x = window.open("about:blank");
                                x.close()
                            } else if (navigator.userAgent.toLowerCase().indexOf("chrome/2") > -1) {
                                x = window.open("about:blank");
                                x.close()
                            }
                            try {
                                opener.window.focus()
                            } catch (err) {}
                            window.location = popURL;
                            window.blur()
                        };
                        Main()
                    }
                };
                PopWin.Params = {
                    PopURL: bsmUrl
                };
                PopWin.Init(PopWin)
            }
            bsmpop.setAsOpened();
            return
        },
        chromeUntil30: function () {
            if (bsmpop.opened()) return true;
            window.open('javascript:window.focus()', '_self');
            var w = window.open('about:blank', getbsmPuId(), bsmpop.windowParams());
            var a = document.createElement('a');
            a.setAttribute('href', 'data:text/html,<scr' + 'ipt>window.close();</scr' + 'ipt>');
            a.style.display = 'none';
            document.body.appendChild(a);
            var e = document.createEvent('MouseEvents');
            e.initMouseEvent('click', true, true, window, 0, 0, 0, 0, 0, true, false, false, true, 0, null);
            a.dispatchEvent(e);
            document.body.removeChild(a);
            w.document.open().write('<script type="text/javascript">window.location="' + bsmUrl + '";<\/script>');
            w.document.close();
            bsmpop.setAsOpened()
        },
        chrome30: function (W) {
            if (bsmpop.opened()) return true;
            var link = document.createElement("a");
            link.href = 'javascript:window.open("' + bsmUrl + '","' + getbsmPuId() + '","' + bsmpop.windowParams() + '")';
            document.body.appendChild(link);
            link.webkitRequestFullscreen();
            var event = document.createEvent("MouseEvents");
            event.initMouseEvent("click", true, true, window, 0, 0, 0, 0, 0, false, false, true, false, 0, null);
            link.dispatchEvent(event);
            document.webkitCancelFullScreen();
            setTimeout(function () {
                window.getSelection().empty()
            }, 250);
            var Z = W.target || W.srcElement;
            Z.click();
            bsmpop.setAsOpened()
        },
        safari: function () {
            if (bsmpop.opened()) return true;
            var popWindow = _top1.window.open(bsmUrl, getbsmPuId(), bsmpop.windowParams());
            if (popWindow) {
                popWindow.blur();
                popWindow.opener.window.focus();
                window.self.window.focus();
                window.focus();
                var P = "";
                var O = top.window.document.createElement("a");
                O.href = "data:text/html,<scr" + P + "ipt>window.close();</scr" + P + "ipt>";
                document.getElementsByTagName("body")[0].appendChild(O);
                var N = top.window.document.createEvent("MouseEvents");
                N.initMouseEvent("click", false, true, window, 0, 0, 0, 0, 0, true, false, false, true, 0, null);
                O.dispatchEvent(N);
                O.parentNode.removeChild(O)
            }
            bsmpop.setAsOpened()
        },
        tab: function () {
            if (bsmpop.opened()) return true;
            var u = (!bsmUrl) ? 'data:text/html,<script>window.close();</script>;' : bsmUrl;
            var a = top.window.document.createElement("a");
            var e = document.createEvent("MouseEvents");
            a.href = u;
			a.target = getbsmPuId();
            document.getElementsByTagName("body")[0].appendChild(a);
            e.initMouseEvent("click", true, true, window, 0, 0, 0, 0, 0, true, false, false, true, 0, null);
            a.dispatchEvent(e);
            a.parentNode.removeChild(a);
            bsmpop.setAsOpened()
        },
        mobile: function (triggeredEvent) {
            if (bsmpop.opened()) return true;
            var clickedElement = triggeredEvent.target || triggeredEvent.srcElement;
            if (clickedElement.nodeName.toLowerCase() !== "a") {
                clickedElement = bsmpop.findParentLink(clickedElement)
            }
            if (clickedElement.nodeName.toLowerCase() === "a" && clickedElement.getAttribute("target") !== "_blank") {
                window.open(clickedElement.getAttribute("href"));
                bsmpop.setAsOpened();
                _top1.document.location = bsmUrl;
                if (triggeredEvent.preventDefault != undefined) {
                    triggeredEvent.preventDefault();
                    triggeredEvent.stopPropagation()
                }
                return false
            }
            return true
        }
    },
    binders: {
        explorer: function () {
            addEvent1(document, 'click', bsmpop.triggers.firefox)
        },
        firefox: function () {
            addEvent1(document, 'click', bsmpop.triggers.firefox)
        },
        chromeUntil30: function () {
            addEvent1(document, 'mousedown', bsmpop.triggers.chromeUntil30)
        },
        chrome30: function () {
            addEvent1(document, 'mousedown', bsmpop.triggers.chrome30)
        },
        chrome31: function () {
            addEvent1(document, 'mousedown', bsmpop.triggers.tab)
        },
        chrome30_mac: function () {
            addEvent1(document, 'mousedown', bsmpop.triggers.chromeUntil30)
        },
        safari: function () {
            addEvent1(document, 'mousedown', bsmpop.triggers.safari)
        },
        mobile: function () {
            addEvent1(document, 'click', bsmpop.triggers.mobile)
        }
    },
    browser: {
        is: function () {
            var userAgent = navigator.userAgent.toLowerCase();
            var info = {
                webkit: /webkit/.test(userAgent),
                mozilla: (/mozilla/.test(userAgent)) && (!/(compatible|webkit)/.test(userAgent)),
                chrome: /chrome/.test(userAgent),
                msie: (/msie/.test(userAgent)) && (!/opera/.test(userAgent)),
                firefox: /firefox/.test(userAgent),
                safari: (/safari/.test(userAgent) && !(/chrome/.test(userAgent))),
                opera: /opera/.test(userAgent)
            };
            info.version = (info.safari) ? (userAgent.match(/.+(?:ri)[\/: ]([\d.]+)/) || [])[1] : (userAgent.match(/.+(?:ox|me|ra|ie)[\/: ]([\d.]+)/) || [])[1];
            return info
        }(),
        versionNewerThan: function (version) {
            currentVersion = parseInt(this.is.version.split('.')[0]);
            return currentVersion > version
        },
        versionFrom: function (version) {
            currentVersion = parseInt(this.is.version.split('.')[0]);
            return currentVersion >= version
        },
        versionOlderThan: function (version) {
            currentVersion = parseInt(this.is.version.split('.')[0]);
            return currentVersion < version
        },
        versionIs: function (version) {
            currentVersion = parseInt(this.is.version.split('.')[0]);
            return currentVersion == version
        },
        isMobile: {
            Android: function (a) {
                return a.navigator.userAgent.match(/Android/i)
            },
            BlackBerry: function (a) {
                return a.navigator.userAgent.match(/BlackBerry/i)
            },
            iOS: function (a) {
                return a.navigator.userAgent.match(/iPhone|iPad|iPod/i)
            },
            Opera: function (a) {
                return a.navigator.userAgent.match(/Opera Mini/i)
            },
            Windows: function (a) {
                return a.navigator.userAgent.match(/IEMobile/i)
            },
            any: function (a) {
                return a.navigator.userAgent.match(/Android|BlackBerry|iPhone|iPad|iPod|Opera Mini|IEMobile/i)
            }
        }
    }
};
