Leaflet and C# WebServices
----

Web Services
----
It use getJSON to get marker information from web service. 
The format of marker information is GeoJSON.

```json
[
  {
    "type": "Feature",
    "properties": {
      "Name": "The Salvation Army Peacehaven Nursing Home",
      "Status": "Operational",
      "IconUrl": "/img/Hospital.png"
    },
    "geometry": {
      "type": "Point",
      "coordinates": [
        "103.7828",
        "1.2951"
      ]
    }
  },
  {
    "type": "Feature",
    "properties": {
      "Name": "The Salvation Army Peacehaven Nursing Home",
      "Status": "Operational",
      "IconUrl": "/img/Hospital.png"
    },
    "geometry": {
      "type": "Point",
      "coordinates": [
        "103.9616977",
        "1.3538414"
      ]
    }
  }
]
```

Leaflet
----
It is to load data into leaflet after getting Marker information.

```Leaflet
 L.geoJson(data, {
	        pointToLayer: function (feature, latlng) {
	            var baseballIcon = L.icon({
	                iconUrl: iconDomain + feature.properties.IconUrl,
	                iconSize: [22, 22],
	                iconAnchor: [16, 37],
	                popupAnchor: [0, -28]
	            });
	            return L.marker(latlng, { icon: baseballIcon });
	        },
	        onEachFeature: onEachFeature
	    }).addTo(map);
```