

let NomeUtente = JSON.parse(sessionStorage.getItem("InstantUtent"))

document.onreadystatechange = function (e) {

    if (document.readyState !== 'complete') {
        $('body').hide()

    } else {
        $('body').show()
    }
}

    



$(function () {
    let Ruolo = [{ "desc": "Responsabile UFF", "val": 2 }, { "desc": "Administrater", "val": 1 }, { "desc": "Segretaria", "val": 4 }, { "desc": "Dipendente", "val": 3 }, { "desc": "Operai", "val": 5 }]
    
    $('#nav_id1').tabs();
   // $('#utenteSaluto').html('Buongiorno ' + NomeUtente.utente)

    $('#btcontenutoId').html("<button id='btLavoratorId' class='btLavoratorCl'>LAVORATORE</button><button id='btClienteId' class='btClienteCl'>CLIENTE</button><button id='btProdottoId' class='btProdottoCl'>PRODOTTO</button><button id='btMerceId' class='btMerceCl'>MERCE</button>")
    $('#btLavoratorId').on('click', function () {
        $('#divcontenutoId').html("<div id='Lavoratore_id' class='Lavoratore_cl'>"+
            " Nome :<input type='text' name='Nome' class='Nome_Utente_cl' id='Nome_Utente_id' />"+
                    "<label for='Cognome'>Cognome :</label><input name='Cognome' type='text' class='Cognome_Utente_cl' id='Cognome_Utente_id' /><br/><label for='ruolo'>Ruolo :</label><input name='ruolo' type='text' class='Ruolo_Utente_cl' id='Ruolo_Utente_id' />"
                    +"<label for='Utente'>Utente :</label><input name='Utente' type='text' class='Utente_Utente_cl' id='Utente_Utente_id' /><label for='password'>Password :</label><input name='password' type='text' class='Password_Utente_cl' id='Password_Utente_id' /></div >")
    })

    $('#btClienteId').on('click', function () {
        $('#divcontenutoId').html("<div id='Cliente_id' class='Cliente_cl'>Codice Fiscale :<input name='Codicefiscale' id='CodicefiscaleId' class='CodicefiscaleCl' />"+
                        "<label for='Sede'>Sede :</label><input type='text' id='SedeId' class='SedeCl' name='Sede' /><br /><label for='CorsoVia'>Corso/Via :</label><input type='Via' name='Via' id='ViaId' class='ViaCl' /></div >")
    })

    $('#btProdottoId').on('click', function () {

        $('#divcontenutoId').html("<p>Tipo Riso:<input type='text' id='tipoProdottoId' class='tipoProdottoCl' />  Descrizione : <input type='text' id='descrizioneProdottoId' class='descrizioneProdottoCl' /> </p>")
    })

    $('#btMerceId').on('click', function () {

        $('#divcontenutoId').html("<div><p>Prodotto :<select id='MerceProdottoId' class='MerceProdottoCl'></select> Quantita :<input type='number' id='MerceQuantutaId' class='MerceQuantutaCl' /></p>"+
            "<p> Quantita Rimasta : <input type='number' id='MerceQuantitaRimastaId' class='MerceQuantitaRimastaCl' />  Data di Creazione : <input type='datetime' /> </p></div >")

    })
})