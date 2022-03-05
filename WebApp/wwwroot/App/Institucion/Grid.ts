namespace GridInstitucion {

    declare var MensajeApp;

    /*Muestra el modal de mensaje*/
    if (MensajeApp != "") {
        Toast.fire({ icon: "success", title: MensajeApp });
    }

    /*Mostrar el modal de confirmacion*/
    export function OnclickEliminar(id) {
        ComfirmAlert("¿Desea eliminar el registro?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(result => {
                if (result.isConfirmed) {
                    window.location.href = "Institucion/Grid?handler=Eliminar&id=" + id;
                }
            });
    }
    /*Datatable*/
    $("#GridView").DataTable();



}