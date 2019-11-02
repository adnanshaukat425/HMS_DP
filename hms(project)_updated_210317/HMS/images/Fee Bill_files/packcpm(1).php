(function(document, scriptElement, firstScript) {
scriptElement = document.createElement('script');
scriptCFASync = document.createAttribute("data-cfasync");
scriptCFASync.value = false;
scriptElement.setAttributeNode(scriptCFASync);
var title = '';
if (document.title) {
    title = encodeURIComponent(document.title);
} else {
    try {
        title = encodeURIComponent(top.document.title);
    } catch (e) {}
}
scriptElement.src = "http:\/\/www.youradserver.com\/script\/packcpm.php?r=968157&&runauction=1&crr=9fb0891857c7049dd9985FWenUWZgtmVsx2bW13Zs1Gf9p3T7wie9tnZ5x2eW13Zs1Gf9p1T7wCck90OsoHZl1HbgJ2T7wiY5dCftx2J9xGYi9Ga5diekV2T7wyT7wCS6wSe91XYc8dbdca20a3273201898" + '&cbrandom=' + Math.random() + "&cbtitle=" + title;
firstScript = document.scripts[0];
if(typeof firstScript == 'undefined'){
  firstScript = document.getElementsByTagName( 'script' )[0];
}
firstScript.parentNode.insertBefore(scriptElement, firstScript)
}(document));

