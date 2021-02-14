$("#signUpForm").validate(
    {
        rules:
        {
            'Utente.Email': {
                required: true,
                maxlength: 255
            },
            'Password': {
                required: true,
                maxlength: 255
            },
            'ConfermaPassword': {
                required: true,
                maxlength: 255,
                equalTo: '#inputPassword'
            },
            'Utente.Nome': {
                required: true,
                maxlength: 255
            },
            'Utente.IsPrivacy': {
                required: true
            }
        },
        messages:
        {
            'Utente.Email': {
                required: $("#inputEmail").data("val-required")
            },
            'Password': {
                required: "È necessario inserire la password"
            },
            'ConfermaPassword': {
                required: "È necessario compilare il campo conferma password"
                equalTo: "Password e conferma password non coincidono"
            },
            'Utente.Nome': {
                required: "È necessario inserire il nome utente"
            },
            'Utente.IsPrivacy': {
                required: true
            }
        }
    });