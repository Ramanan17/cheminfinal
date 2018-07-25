"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var dataservice_service_1 = require("./dataservice.service");
describe('DataserviceService', function () {
    beforeEach(function () {
        testing_1.TestBed.configureTestingModule({
            providers: [dataservice_service_1.DataserviceService]
        });
    });
    it('should be created', testing_1.inject([dataservice_service_1.DataserviceService], function (service) {
        expect(service).toBeTruthy();
    }));
});
//# sourceMappingURL=dataservice.service.spec.js.map