$(document).ready(function () {
    //$('#particlarsTable').DataTable();
    searchAll(); 
 


    $("#btnSh").click(function () {

        var Id = $("#txtid").val();
        console.log(Id); 
        searchById(Id); 
     
    });





  


    function searchAll() {
       
        $('#employeeTable').DataTable({
            destroy: true,
            searching: false,
            ajax: {
                url: '/Employee/GetEmployeesFromService/',
                "dataSrc": "",

            },
            columns: [
                { data: 'id' },
                { data: 'name' },
                { data: 'contractTypeName' },
                { data: 'roleId' },
                { data: 'roleName' },
                { data: 'roleDescription' },
                { data: 'annualSalary' },


            ],
           
        });
    }


    function searchById(idEmplo) {

        $('#employeeTable').DataTable({
            destroy: true,
            searching: false,
            ajax: {
                url: 'Employee/GetEmployeesFromService/?Id=' + idEmplo,
                "dataSrc": "",
              

            },
            columns: [
                { data: 'id' },
                { data: 'name' },
                { data: 'contractTypeName' },
                { data: 'roleId' },
                { data: 'roleName' },
                { data: 'roleDescription' },
                { data: 'annualSalary' },


            ],
            
        });

    }

});  