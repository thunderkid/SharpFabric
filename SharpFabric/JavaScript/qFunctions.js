
var canvas = new fabric.Canvas('qcanv');
    canvas.selectionColor = 'rgba(0,255,0,0.3)';
    canvas.selectionBorderColor = 'green';
    canvas.selectionLineWidth = 5;


function qJsCircle(x, y)
{
    //alert("weeeee");
    var circle = new fabric.Circle({ radius: 20, fill: '#f55', top: y, left: x });

    canvas.add(circle);

    return circle;
}


function qMove(obj, x, y)
{
    


}






