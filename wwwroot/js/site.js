


$(document).ready(function(){
    $("#postform").submit(function(e){
        e.preventDefault();
        
        var item = {
            "FirstName" : $("#firstName").val().trim(),
            "LastName" : $("#lastName").val().trim(),
            "Email" : $("#Email").val().trim()
            }

            $.ajax({
                type:"POST",
                url: "api/contacts",
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(item),
                success: function(result) {
                  alert("Your data has been submitted!");
                  $("#firstName").val("");
                  $("#lastName").val("");
                  $("#Email").val("");
                },
                error: function(jqXHR, textStatus, errorThrown) {
                    alert("Something went wrong!");
                  }
              })
        

    })

    getAll();
    function getAll(){
        $.ajax({
            type:"GET",
            url: "api/contacts",
            contentType: "application/json",
            success:function(data){
                console.log(data);
            }




        })

    }
})

   

