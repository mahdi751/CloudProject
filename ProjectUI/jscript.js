var typed = new Typed(".header-description", {
  strings: [
    "is the language of the spirit. It opens the secret of life bringing peace, abolishing strife.^1000",
    "gives a soul to the universe, wings to the mind, flight to the imagination and life to everything.^1000",
    "is the only medicine the heart and soul need.^1000",
  ],
  typeSpeed: 15,
  backSpeed: 15,
  loop: true,
});

function formValidation() {
  var submission = true;

  // Validate full name
  if (document.registrationForm.full_name.value === "") {
    submission = false;
    alert("Please enter your username");
  }

  // Validate email
  if (document.registrationForm.email.value === "") {
    submission = false;
    alert("Please enter your email address.");
  }

  // Validate password
  if (document.registrationForm.password.value === "") {
    submission = false;
    alert("Please enter your password.");
  }

  return submission;
}

function registerUser() {
  if (true) {
    // Form is valid, proceed with API call
    var formData = {
      Username: document.form.full_name.value,
      Email: document.form.email.value,
      Password: document.form.password.value
    };

    // Make API call
    fetch('https://localhost:7240/api/Account/register', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(formData),
    })
    .then(response => response.json())
    .then(data => {
      // Handle API response
      alert("User registered successfully!");
      console.log(data);
    })
    .catch(error => {
      // Handle errors
      alert("Error registering user. Please try again.");
      console.error('Error:', error);
    });
  }
}
