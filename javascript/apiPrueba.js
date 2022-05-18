const urlBase = "https://localhost:44345/";

const MetodoGet = () => {
    fetch(`$(urlBase)/api/person/all`)
    .then(Response => Response.json())
    .then(data => console.log("Metodo Get api", data))
};

// const MetodoGet2 = (id) => {
//     fetch(`$(urlBase)/api/person/${id}`)
//     .then(Response => Response.json())
//     .then(data => console.log("Metodo Get api", data))
// };

// const MetodoPost = () => {
//     const person = {
//         id: 19,
//         name: "Daniel",
//         age: 28,
//         email: "correoDaniel@correo.com",
//         createdDate: "2020-05-17"
//     }

//     fetch(`${urlBase}/api/Person`,{
//         method: 'POST',
//         body: JSON.stringify(person),
//         headers: {
//             'Content-Type': 'application/json'
//         }
//     })
//     .then(response => response.json())
//     .then(data => console.log("Metodo POST api", data))
// };

// const MetodoPut = () => {
//     const person = {
//         id: 3,
//         name: "Daniel",
//         age: 28,
//         email: "correoDaniel@correo.com",
//         createdDate: "2020-05-17"
//     }

//     fetch(`${urlBase}/api/Person`,{
//         method: 'PUT',
//         body: JSON.stringify(person),
//         headers: {
//             'Content-Type': 'application/json'
//         }
//     })
//     .then(response => response.json())
//     .then(data => console.log("Metodo PUT api", data))
// };

// const MetodoDelete = (id) => {
//     fetch(`${urlBase}/api/Person`,{
//         method: 'DELETE',
//         body: JSON.stringify(id),
//         headers: {
//             'Content-Type': 'application/json'
//         }
//     })
//     .then(response => response.json())
//     .then(data => console.log("Metodo DELETE api", data))
// };

// const MetodoDelete2 = (id) => {
//     fetch(`${urlBase}/api/Person/${id}`,{
//         method: 'DELETE'
//     })
//     .then(response => response.json())
//     .then(data => console.log("Metodo DELETE api", data))
// };



MetodoGet();
// MetodoGet2(4);
// MetodoPost();
// MetodoPut();
// MetodoDelete(5);
// MetodoDelete2(5);