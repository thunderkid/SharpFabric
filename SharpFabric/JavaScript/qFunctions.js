
var canvas = new fabric.Canvas('qcanv');

function qJsCircle(x, y)
{
    //alert("weeeee");
    canvas.add(new fabric.Circle({ radius: 30, fill: '#f55', top: y, left: x }));

    canvas.selectionColor = 'rgba(0,255,0,0.3)';
    canvas.selectionBorderColor = 'red';
    canvas.selectionLineWidth = 5;
}