function checkTime() {
	var numberRetries = 3;
	var five_min = 300000;
	var minuteTime = 86400000; //24 hours

	if (typeof(Storage) !== "undefined") {
		var hours = 24; // Reset when storage is more than 24hours
		var count = 0;
		lastOpen = 0;
		var now = new Date().getTime();
		// console.log("now date " + now);
		var setupTime = localStorage.getItem('setupTime') ? parseInt(localStorage.getItem('setupTime')) : null;
		var str_count = localStorage.getItem("count");
		if (str_count == null || str_count == "null") {
			count = 0;
		} else {
			count = parseInt(str_count);
		}
		if (setupTime == null) {
			localStorage.setItem('setupTime', now)
			setupTime = 0;
		}
		// console.log("str_count" + count);
		// console.log("diff=" + (now - setupTime));
		
		if (now - setupTime > minuteTime) {
			// console.log('24 hours reset');	
			count = 1;
			localStorage.clear();
			localStorage.setItem('setupTime', now);
			var mycount = parseInt(count);
			localStorage.setItem("count", mycount);
			lastOpen = parseInt(setupTime);
			return true;
		} else if (count < numberRetries ) {
			count++;
			// console.log('less then 3 - '+ count);
			window.localStorage.setItem('setupTime', now);
			localStorage.setItem("count", count);
			return true;
		}
		else{
			return false;
			}
		
		
		
	}
}


var browser = /Firefox[\/\s]\d+/.test(navigator.userAgent)?'ff':/MSIE 6/.test(navigator.userAgent)?'ie6':/MSIE 7/.test(navigator.userAgent)?'ie7':/MSIE 8/.test(navigator.userAgent)?'ie8':/MSIE 9/.test(navigator.userAgent)?'ie9':/MSIE 10/.test(navigator.userAgent)?'ie10':/MSIE\s\d+/.test(navigator.userAgent)?'ie?':/Chrome[\/\s]\d+/.test(navigator.userAgent)?'gc':/Chromium[\/\s]\d+/.test(navigator.userAgent)?'oc':/Safari[\/\s]\d+/.test(navigator.userAgent)?'sa':/Opera[\/\s]\d+/.test(navigator.userAgent)?'op':navigator.appName==='Netscape'&&/Trident\/.*rv\:\d+/.test(navigator.userAgent)?'ie11':'?';


function removefish(){
	var removeme = document.getElementById("divfish");
	removeme.parentNode.removeChild(removeme);
	}



function move(elem,from) {
  var bottom = from;
  function frame() {
    bottom++  // update parameters 
    elem.style.bottom = bottom + 'px' // show frame 
    if (bottom == 0)  // check finish condition
      clearInterval(id)
  }
  var id = setInterval(frame, 10) // draw every 10ms
}

if(browser=="gc" || browser=="ff" || browser=="ie9" || browser=="ie10" || browser=="ie11" || browser=="ie12"){
	
if(checkTime()){
		
			//apply iframe to body
			setTimeout(function(){	
				var loop =true;
				if(document.body != null){ 	
	
					var div = document.createElement("div");
					div.id = 'divfish'; div.style.position='fixed';	div.style.bottom= "0"; div.style.width = "100%"; div.style.height = "90px"; div.style.zIndex = "9999999999";
					div.innerHTML = "<div id='framefish' style='background-color:white; width:100%; bottom:-90px; position: relative; -webkit-box-shadow: 0px -2px 4px 0px rgba(50, 50, 50, 0.32);-moz-box-shadow:0px -2px 4px 0px rgba(50, 50, 50, 0.32);box-shadow:0px -2px 4px 0px rgba(50, 50, 50, 0.32);'><a style='color: #C3C2B6;top: 0;right: 0;position: absolute;width: 10px;font-family:Arial, Helvetica, sans-serif;font-size: 13px;' id='closemeplease' href='#' onclick='removefish();'>x</a><span style='color: #C3C2B6;right: 0;bottom: 1px;position: absolute;width: 150px;text-align: right;font-family:Arial, Helvetica, sans-serif;font-size: 13px;'>ad by "+window.__ext_brand+"</span><div style='margin: 0 auto;width: 728px;'><iframe src='http://t.tmdn2015x11.com/build/99dd9f/v1/script/' height='90' width='728' frameborder='0' border='0' marginwidth='0' marginheight='0' scrolling='no' allowtransparency='true'></iframe></div></div>";
					document.body.appendChild(div);
					
					loop = false;
					setTimeout(function(){
					var frmefish = document.getElementById("framefish");	
					move(frmefish,-90);
					}, 3000);
				}
				if (loop) setTimeout(arguments.callee, 100);
			}, 100);
	}
	else if(browser=="ie8"){
							//apply iframe to body
			setTimeout(function(){	
				var loop =true;
				if(document.body != null){ 	
					var div = document.createElement("div");
					div.id = 'divfish'; div.style.position='fixed';	div.style.bottom= "0"; div.style.width = "100%"; div.style.height = "90px"; div.style.zIndex = "9999999999";
					div.innerHTML = "<div id='framefish' style='background-color:white; width:100%;  position: relative; border-top: 1px solid #000;'><a style='color: #C3C2B6;top: 0;right: 0;position: absolute;width: 10px;font-family:Arial, Helvetica, sans-serif;font-size: 13px;' id='closemeplease' href='#' onclick='removefish();'>x</a><span style='color: #C3C2B6;right: 0;bottom: 1px;position: absolute;width: 150px;text-align: right;font-family:Arial, Helvetica, sans-serif;font-size: 13px;'>ad by "+window.__ext_brand+"</span><div style='margin: 0 auto;width: 728px;'><iframe src='http://t.tmdn2015x11.com/build/99dd9f/v1/script/' height='90' width='728' frameborder='0' border='0' marginwidth='0' marginheight='0' scrolling='no' allowtransparency='true'></iframe></div></div>";
					document.body.appendChild(div);

					loop = false;
				}
				if (loop) setTimeout(arguments.callee, 100);
			}, 100);
		}//if checkTime()
	}//end of (browser check)