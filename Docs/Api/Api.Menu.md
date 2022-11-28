# Create Menu

```js
POST /hosts/{hostId}/menus
```

### Create Menu Request

```json
{
    "name" : "Yummy menu",
    "description" : "A menu with yummy food",
    "section" : [
        {
            "name" : "Appetizers",
            "description" : "Starters",
            "items": [
                {
                    "name" : "Fried Pickles",
                    "description" : "Deep fried pickles"
                }
            ]
        }
    ]
}
```
