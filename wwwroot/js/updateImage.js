$(document).ready(function () {
    $('.visibilityCheckbox').change(function () {
        var imageId = $(this).data('image-id');
        var isVisible = $(this).prop('checked');

        $.ajax({
            url: '/ChoosePhotos/ToggleImageVisibility',
            type: 'POST',
            data: {
                imageId: imageId,
                isVisible: isVisible,
            },
            success: function (result) {
                if (result.success) {
                    console.log('Успішно виконано');
                } else {
                    console.log('Помилка виконання');
                }
            },
            error: function (error) {
                console.error('Помилка при відправці AJAX-запиту:', error);
            }
        });

    });
});