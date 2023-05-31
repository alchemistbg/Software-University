function attachEvents() {
    let $buttons = $('a.button').on('click', (e) => {
        //e.preventDefault();
        //e.stopPropagation();

        const $target = $(e.target);
        if (!$target.hasClass('selected')) {
            if ($target.siblings().hasClass('selected')) {
                $target.siblings().removeClass('selected');
            }
            $target.addClass('selected');
        } else {
            $target.removeClass('selected');
        }
    });
}
