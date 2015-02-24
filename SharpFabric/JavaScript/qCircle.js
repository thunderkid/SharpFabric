//document.body.style.backgroundColor = "red"

var canvas = new fabric.Canvas('qcanv');
//alert("weeeee");
canvas.add(new fabric.Circle({ radius: 30, fill: '#f55', top: 100, left: 100 }));

canvas.selectionColor = 'rgba(0,255,0,0.3)';
canvas.selectionBorderColor = 'red';
canvas.selectionLineWidth = 5;
