$(function () {
    
    $('#section_Index_id').html("<p><label for='utente'>Utente:</label><input name='utente' type='text' id='utente_id' class='utente_cl' size='23'></p>")
    $('#section_Index_id').append("<p><label for='password'></label >Password :<input name='password' id='password_Id' class='password_Cl' /></p>")
    $('#section_Index_id').append("<p><button id='invio_id' class='invio_cl '>Invio</button><button id='cancel_id' class='cancel_cl '>Cancel</button></p>")
    
    $('button').attr('disabled', 'disabled')

                                 
    $('input').on('keyup', function () {
            if ($('#utente_id').val().length >=5 && $('#password_Id').val().length>=8) {
                $('button').removeAttr('disabled')
            } else if ($('#utente_id').val().length<5 || $('#password_Id').val().length<8) {
                $('button').attr('disabled', 'disabled')
            }

        })
  

    
      
    $('#invio_id').on('click', function () {

        $.ajax({
            url: '../VB/Index.aspx',

            data: {

                UT: $('#utente_id').val(),
                PSWD: $('#password_Id').val()
            },
            type: 'POST',
            datatype: 'JSON',

            success: function (dati, status) {

                if (dati != "Non") {

                    sessionStorage.setItem('InstantUtent', dati)//recupera la session del utente
                    console.log('InstantUtent', new Date().getFullYear())


                    window.location.pathname = "../Templates/Home.html"
                    //console.log("pagina 2")
                    //window.location.href = '../Templates/Home.html'

                } else {

                    alert('utente sbagliato')
                }








                console.log(NomePerson)



            },
            Error: function () { }
        })

    }) 

    


})

//$(document).ready(function () {
   
     
    
//})                                                                                                               