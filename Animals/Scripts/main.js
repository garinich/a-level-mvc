jQuery(document).ready(function(){
    var theme = $('a.theme');
    var $body = $('body');

    theme.on('click', function(){
        if(!$body.hasClass('dark')) {
            $body.addClass('dark');
            theme.text('White theme');
        } else {
            $body.removeClass('dark');
            theme.text('Dark theme');
        }
        return false;
    });
});
