$(document).ready(function () {
    cargarDataTable();
});

var dataTable;

function cargarDataTable() {
    dataTable = $('#tablaClientes').DataTable({
        language: {
            url: '//cdn.datatables.net/plug-ins/1.10.15/i18n/Spanish.json'
        },
        "ajax": {
            "type": "GET",
            "datatype": "json",
            "url": "/Main/API/GetCustomerList"
        },
        "columns": [
            { "data": "id", "witdh": "10%" },
            { "data": "lastName", "witdh": "60%" },
            { "data": "firstName", "witdh": "10%" },
            { "data": "address", "witdh": "10%" },
            { "data": "phone", "witdh": "10%" },
            { "data": "email", "witdh": "10%" },
            {
                "data": "id",
                "width": "20%",
                "render": function (data) {
                    return `<div class="text-center"><a class="btn btn-primary" href="/Main/Customers/Edit/${data}">Editar</a> &nbsp;<a class="btn btn-danger text-white" style="cursor:pointer;" onclick="Delete('/Main/API/Delete/${data}')">Eliminar</a></div>`
                }
            }
        ],
    });
}

function Delete(urlDestino) {
    swal.fire({
        title: "Estás seguro de querer borrar el registro?",
        text: "Ésta accion no se podrá deshacer.",
        icon: "warning",
        showCancelButton: true,
        confirmButtonText: "Si, estoy seguro",
        cancelButtonText: "Cancelar"
    }).then(function () {
        //Llamar al recurso eliminar categoria de la api
        $.ajax({
            type: "DELETE", //Tipo de petición
            url: urlDestino,  //url del recurso
            success: function (respuesta) { //La los nodos "success", "message", fueron los que yo construí en la respuesta del JSON en la acción Eliminar de ApiController  el nodo SUCCESS de la llamada AJAX recibe como parámetro un callback
                if (respuesta.success == true) {
                    toastr.success(respuesta.message);
                    dataTable.ajax.reload();
                } else {
                    toastr.error(respuesta.message);
                }
            }
        })
    })
    
}

