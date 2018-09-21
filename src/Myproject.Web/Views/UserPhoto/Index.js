(function () {
    $(function () {

        var _authorService = abp.services.app.userPhoto;
        var _$modal = $('#UserPhotoUploadModal');
        var _$form = _$modal.find('form');

        _$form.validate();
        $('#RefreshButton').click(function () {
            refreshTenantList();
        });
        $('.delete-author').click(function () {
            var authorId = $(this).attr("data-book-id");
            var authorName = $(this).attr('data-book-name');

            deleteTenant(authorId, authorName);
        });
        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var tenant = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
            abp.ui.setBusy(_$modal);
           Debug.Log(tenant)
            _authorService.create(tenant).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new tenant!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });


        function refreshTenantList() {
            location.reload(true); //reload page to see new tenant!
        }
        function deleteTenant(authorId, authorName) {


            _authorService.delete({
                id: authorId
            }).done(function () {
                refreshTenantList();
            });


        }


    });
})();