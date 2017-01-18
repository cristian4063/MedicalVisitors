(function () {
    var controllerId = 'app.views.evaluations';
    angular.module('app').controller(controllerId, [
        '$scope', function ($scope) {
            var vm = this;

            vm.show = false;

            vm.showTable = function () {
                vm.show = true;
            }
        }
    ]);
})();