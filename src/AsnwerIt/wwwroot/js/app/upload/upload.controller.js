(function () {
    'use strict';

    angular
        .module('answerit')
        .controller('UploadController', UploadController);

    UploadController.$inject = [];

    function UploadController() {
        var vm = this;

        vm.upload = "Tela upload";


        activate();

        ////////////////

        function activate() {}
    }
})();