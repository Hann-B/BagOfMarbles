let addToList = (data) => {
    $("#marbleList").append($("<li>").html(data.Color));
}


let talkToServer = () => {

    let newMarble = {
        color: $("#newMarbleColor").val()
    };

    $.ajax({
        url: '/api/Marble',
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(newMarble),
        type: "POST",
        success: (data) => {
            addToList(data);
        },
        error: (data) => {
            console.log("opps", data);
        },
        complete: (data) => {
            console.log("done", data);
        }
    });
}

let loadMarbles = () => {
    $.ajax({
        url: "/api/Marble",
        dataType: "json",
        success: (data) => {
            data.map((item) => { addToList(item); });
        }

    })
}

let pickMarble = () => {
    // a number, between 0  and the number of li in the ul
    let children = $("#marbleList").children();
    //  console.log(children.length);
    // create a random between 1 and 3
    random = Math.floor(Math.random() * children.length);
    // console.log(random);
    console.log(children[random].innerHTML);
    theMarble(children[random].innerHTML);
}

let theMarble = (data) => {
    $("#pickedMarble").html(data);
}

loadMarbles();