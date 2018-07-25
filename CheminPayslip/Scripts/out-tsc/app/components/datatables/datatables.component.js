"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var dataservice_service_1 = require("../../services/dataservice.service");
var DatatablesComponent = /** @class */ (function () {
    function DatatablesComponent(dataservice) {
        var _this = this;
        this.dataservice = dataservice;
        this.dataservice.getSites().subscribe(function (m) {
            _this.sites = m;
            console.log(_this.sites);
        });
    }
    DatatablesComponent.prototype.ngOnInit = function () {
    };
    DatatablesComponent = __decorate([
        core_1.Component({
            selector: "app-datatables",
            templateUrl: './datatables.component.html',
            styleUrls: ['./datatables.component.css']
        }),
        __metadata("design:paramtypes", [dataservice_service_1.DataserviceService])
    ], DatatablesComponent);
    return DatatablesComponent;
}());
exports.DatatablesComponent = DatatablesComponent;
//# sourceMappingURL=datatables.component.js.map