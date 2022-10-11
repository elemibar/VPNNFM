document.querySelector('#btnAddIPToList').addEventListener("click", sendToControl);
document.querySelector('#btnBuscar').addEventListener("click", sendToControl);


function removeIPFromListf(tabIpRow) 
{

    tabIpRow.parentNode.parentNode.remove();

}


function sendToControl(event)
{
    console.log("In");
    event.preventDefault();
    event.stopPropagation();

    var JsonString = "";

    var formJson = returnFormAsJson();
    var tableJson = returnVPNsTableAsJson();

    console.log("FormAsJson: " + formJson);
    console.log("TableAsJson: " + tableJson);

    if ((formJson != null && formJson != "") || (tableJson != null && tableJson != ""))
    {
        JsonString = `[
            `;

        if (formJson != "") JsonString += formJson;

        if (formJson != null && formJson != "" && tableJson != null && tableJson != "")
        {
            JsonString += `,
                `;
        }

        if (tableJson != null && tableJson != "") JsonString += tableJson;


        JsonString += `
                ]`
    }

    sendToControlAjax(JsonString);

}

function returnFormAsJson()
{

    let newIp = document.querySelector("#txtIp").value;
    let newInicio = document.querySelector("#dtInicio").value;
    let newFin = document.querySelector("#dtFin").value;
    let newTipo = document.querySelector("#selTipo").value;
    var newVPN = "";

    if ((newIp != "") || (newInicio != "") || (newFin != ""))
    {
        newVPN =
            `{
                "Ip": "${newIp}",
                "Alta": "${newInicio}",
                "Baja": "${newFin}",
                "Tipo": 0
            }`;
    }
    else
    {
        newVPN = "";
    }

    return newVPN;

}

function returnVPNsTableAsJson()
{

    var tablaRows = document.querySelectorAll("#tabVpns tbody tr");
    let newTabIp = "";
    let newTabInicio = "";
    let newTabFin = "";
    let newTabTipo = "";
    var vpnListJson = "";

    if (tablaRows != null)
    {
        console.log("TablaRows!=null");
        if (tablaRows.length > 0)
        {
            console.log("TablaRows length > 0");

            for (let i = 0; i < tablaRows.length; i++)
            {
                let newTabIp = tablaRows[i].querySelectorAll("td")[1].innerHTML.trim();

                let newTabInicio = tablaRows[i].querySelectorAll("td")[2].innerHTML.trim();

                let newTabFin = tablaRows[i].querySelectorAll("td")[3].innerHTML.trim();

                let newTabTipo = tablaRows[i].querySelectorAll("td")[4].innerHTML.trim();


                vpnListJson +=
                    `{
                        "Ip": "${newTabIp}",
                        "Alta": "${newTabInicio}",
                        "Baja": "${newTabFin}",
                        "Tipo": 0
                    }`;
                if (i != tablaRows.length - 1)
                    vpnListJson += `,
                        `;
            }
        }
        else
        {
            vpnListJson = "";
        }
    }

    console.log("Tablas as Json: " + vpnListJson);

    return vpnListJson;
}

function sendToControlAjax(data)
{

    var dataType = 'application/json; charset=utf-8';
    console.log("Data: " + data);
    $.ajax({
        type: 'POST',
        url: "../Actividad/Test",
        //dataType: 'json',
        contentType: dataType,
        data: data,
        success: function (result)
        {
            console.log("Success");
            $('#searchForm').empty();
            $('#searchForm').html(result);
        },
        error: function (result)
        {
            console.log("Error");
            console.log(result);
            $('#searchForm').empty();
            $('#searchForm').html(result.responseText);
        }
    });

}