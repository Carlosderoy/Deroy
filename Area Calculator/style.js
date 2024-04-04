function calculateArea() {
    var shape = document.getElementById('shapeSelect').value;
    var side1 = parseFloat(document.getElementById('Base/Side1/Length').value);
    var side2 = parseFloat(document.getElementById('Breadth/Side2/Height').value);
    var radius = parseFloat(document.getElementById('radius if circle').value);
    var area = 0;

    if (shape === 'triangle') {
        area = 0.5 * side1 * side2;
    } else if (shape === 'rectangle') {
        area = side1 * side2;
    } else if (shape === 'circle') {
        area = Math.PI * Math.pow(radius, 2);
    } else if (shape === 'square') {
        area = side1 * side1;
    }

    document.getElementById('result').innerHTML = 'Area: ' + area.toFixed(2);
}