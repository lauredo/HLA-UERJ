(function () {
    'use strict';

    angular
        .module('answerit')
        .controller('UploadController', UploadController);

    UploadController.$inject = [];

    function UploadController() {
        var vm = this;
    
        vm.upload = upload;
        vm.uploader = {};

        activate();

        ////////////////

        function activate() { }

        function upload() {
            vm.uploader.flow.upload();

            console.log(vm.uploader.flow.files);
        }
    }
})();