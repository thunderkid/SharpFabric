﻿
var canvas = new fabric.Canvas('qcanv');
    canvas.selectionColor = 'rgba(0,255,0,0.3)';
    canvas.selectionBorderColor = 'green';
    canvas.selectionLineWidth = 5;

// dictionary object that stores things added to canvas by a unique id. 
    var things = {};


function qJsCircle(uid, x, y)
{
    //alert("weeeee");
    var circle = new fabric.Circle({ radius: 20, fill: '#f55', top: y, left: x });

    circle.on('moving', function () { notifyMoving(uid); });


    canvas.add(circle);

    var triangle = new fabric.Triangle({ width: 20, height: 30, fill: 'blue', left: 50, top: 50 });

    canvas.add(triangle);
    things["trianglepunk"] = triangle;


    things[uid] = circle;

    circle.set({ left: 200 });
    canvas.renderAll();


    return circle;
}


function qJsMove(uid, x, y)
{
    things[uid].set({ left: x, top: y });
    canvas.renderAll();
}


function qJsDelete(uid)
{
    canvas.remove(things[uid]);
    canvas.renderAll();
    delete things[uid];
}


function qJsSetDrawingMode()
{
    canvas.isDrawingMode = true;
}


function notifyMoving(uid)
{
    var circlex = things[uid].get('left');
    callbackObj.tellMe("we are at " + circlex);
    callbackObj.tellMe("with objects " + canvas.getObjects());
    things["trianglepunk"].set({ angle: circlex + 88 });

    callbackObj.tellMeNum(circlex);
}






