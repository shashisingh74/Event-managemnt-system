document.getElementById("eventForm").addEventListener("submit", function(e) {
  e.preventDefault();

  const name = document.getElementById("eventName").value;
  const date = document.getElementById("eventDate").value;
  const time = document.getElementById("eventTime").value;
  const location = document.getElementById("eventLocation").value;

  const eventItem = document.createElement("li");
  eventItem.innerHTML = `
    <strong>${name}</strong><br>
    Date: ${date} | Time: ${time}<br>
    Location: ${location}
  `;

  document.getElementById("events").appendChild(eventItem);

  // Reset the form
  document.getElementById("eventForm").reset();
});
