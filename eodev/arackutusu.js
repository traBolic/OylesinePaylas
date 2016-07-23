// ==UserScript==
// @name         eodev Tools
// @namespace    http://eodev.com/
// @version      0.1
// @description  eodev Araç kutusu
// @author       null
// @icon         https://styleguide.brainly.com/images/favicons/eodev/favicon-3929c74edf.ico
// @match        http://eodev.com/tasks/archive_mod
// @require      http://sosyal.one/eodev/js/jquery.mutation-listener.js
// @resource     eodev.com  http://sosyal.one/eodev/css/eodev.com.css
// @grant        GM_addStyle
// @grant        GM_getResourceText
// @grant        unsafeWindow
// ==/UserScript==

(function() {
    'use strict';
    var jsCss = GM_getResourceText ("eodev.com");
    GM_addStyle (jsCss);
    var jQuery = unsafeWindow.jQuery, $ = jQuery;
    $('#moderation-all > div.content').add_mutation_listner('.moderation-item', 'taskInsert');

    var sayi = 0;
    $(document).on('taskInsert', function(e) {
        if ($('#moderation-all > div.content > .moderation-item').length > sayi)
            sayi++;
        else
            sayi = 1;
        var thisPrt = $('#moderation-all > div.content > .moderation-item:nth-child(' + sayi + ')');
        thisPrt.attr('id', thisPrt.find('.task-url').text());
    });
    $('body').on('mousedown', 'div.contener.mod.moderation', function(e) {
        var This = this;
        if ($(e.target).is('.contener, .mod, .moderation') && e.which === 1) {
            var ofset = e.offsetX;
            var id = $(this).find('.moderation-task').attr('class').match(/(\d{1,})/)[1];
            var boxPrt = $('#' + id + '.moderation-item');
            var elementler = [];
            if (ofset > e.target.offsetWidth) {
                elementler = boxPrt.nextAll('.moderation-item');
            } else if (ofset < 0) {
                elementler = boxPrt.prevAll('.moderation-item');
            }
            $.when($('#toplayer > div.contener-center.mod > div > div.title > div > div.close').click()).done(function() {
                if (elementler.length > 0) {
                    $('div.header > button > i', filtrele(elementler,id).eq(0)).click();
                }
            });
        }
    }).on('keydown', function(e) {
        if (e.keyCode === 27) {
            $('#toplayer > div.contener-center.mod > div > div.title > div > div.close').click();
        }
    }).delegate('div.mint-layout > div.mint-layout__container > section > div.mint-stream > div.js-main-stream.mint-stream__hole *', " click", function(e) {
        /*$('article *').click(function (e) {*/
        e.preventDefault();
        e.stopPropagation();
        console.log($(this));
    });
})();
function filtrele(a,b) {
    return a.filter(function(index) {
        return ($(this).find('.btn-danger.disabled').length > 0 || $(this).attr('id')==b) ? false : true;
    });
}
