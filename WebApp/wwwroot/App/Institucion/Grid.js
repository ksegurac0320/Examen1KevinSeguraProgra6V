"use strict";
var GridInstitucion;
(function (GridInstitucion) {
    /*Muestra el modal de mensaje*/
    if (MensajeApp != "") {
        Toast.fire({ icon: "success", title: MensajeApp });
    }
    /*Mostrar el modal de confirmacion*/
    function OnclickEliminar(id) {
        ComfirmAlert("¿Desea eliminar el registro?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Institucion/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    GridInstitucion.OnclickEliminar = OnclickEliminar;
    /*Datatable*/
    $("#GridView").DataTable();
})(GridInstitucion || (GridInstitucion = {}));
//# sourceMappingURL=Grid.js.map