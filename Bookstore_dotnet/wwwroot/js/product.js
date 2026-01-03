$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {url: '/admin/product/getall'},
        "columns": [
            { data: 'title', "width": '25%' },
            { data: 'listPrice', "width": '15%' },
            { data: 'isbn', "width": '10%' },
            { data: 'author', "width": '15%' },
            { data: 'category.name', "width": '10%' },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                     <a onclick="Delete('/admin/product/delete/${data}')" class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`
                },
                "width": "25%"
            }
        ]
    });
}

function Delete(url) {
    if (confirm('Are you sure you want to delete this product?')) {
        $.ajax({
            url: url,
            type: 'POST',
            success: function (data) {
                dataTable.ajax.reload();
                toastr.success(data.message);
            }
        });
    }
}
