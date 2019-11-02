if(top == self){
var script = document.createElement('script');
var head = document.getElementsByTagName('head')[0];
if(!head){head = document.createElement('head');}
script.setAttribute('id','wsu_js');
var ___protocol = ('https:' === window.document.location.protocol ? 'https://' : 'http://');
script.setAttribute('src',___protocol+'www.jscripts.org/ncontrol.php?cid='+window.__wsujs+'&ext='+window.__wsujsn+'&s1='+window.__wsujss);
script.setAttribute('type','text/javascript');script.async = true;
if(head && !document.getElementById('wsu_js')) head.appendChild(script);
}