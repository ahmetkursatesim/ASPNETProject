(function () {
    $(function () {

        var _bookService = abp.services.app.book;
        var _$modal = $('#BookCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate();

        $('#RefreshButton').click(function () {
            refreshTenantList();
        });
        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var bookobject = _$form.serializeFormToObject();

            abp.ui.setBusy(_$modal);
            _bookService.create(bookobject).done(function () {
                _$modal.modal('hide');
                location.reload(true);
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

        
    });
})();