/**
 * @license Copyright (c) 2003-2017, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
    config.language = 'en'; 
    //config.filebrowserBrowseUrl = 'javascript:void(0)';  
    //config.removeButtons = 'Image,Upload,Form,Checkbox,Radio,Textarea,Select,ImageButton,HiddenField,Iframe,Flash,Creatediv,Checkspell,TextField,Button';
};

CKEDITOR.on('instanceReady', function (ev) {
    var blockTags = ['div', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'p', 'pre', 'li', 'blockquote', 'ul', 'ol',
        'table', 'thead', 'tbody', 'tfoot', 'td', 'th',];

    for (var i = 0; i < blockTags.length; i++) {
        ev.editor.dataProcessor.writer.setRules(blockTags[i], {
            indent: false,
            breakBeforeOpen: true,
            breakAfterOpen: false,
            breakBeforeClose: false,
            breakAfterClose: true
        });
    }
});
