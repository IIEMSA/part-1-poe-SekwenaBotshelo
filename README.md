[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/CI6k5J4n)
ChatGPT Referances:
OpenAI, 2025. ChatGPT [online] Available at: https://chat.openai.com [Accessed 7 Apr. 2025].
(OpenAI, 2025)
Add the About Text to the View:
"@{
    ViewData["Title"] = "About";
}

<div class="container mt-5">
    <h1 class="display-4">About EventEase</h1>
    <p class="lead">
        <strong>EventEase</strong> is your trusted solution for streamlined venue and event management. Designed with booking specialists and event organizers in mind, our platform simplifies the process of finding, managing, and securing event spaces—all in one place.
    </p>
    <p>
        Whether you're organizing a conference, wedding, concert, or corporate function, EventEase ensures a seamless experience by preventing double bookings, managing availability in real time, and securely storing all booking data in the cloud. Our user-friendly interface and robust features empower teams to focus on creating memorable events, not paperwork.
    </p>
    <p>
        Built on modern web technologies and hosted in the cloud, EventEase is scalable, secure, and ready to grow with your needs. We're committed to making event planning effortless, efficient, and enjoyable.
    </p>
</div>"

Minimal Index.cshtml (Home Page):
OpenAI, 2025. ChatGPT [online] Available at: https://chat.openai.com [Accessed 7 Apr. 2025].
(OpenAI, 2025)
"@{
    ViewBag.Title = "Welcome to EventEase";
}

<div class="text-center mt-5">
    <h1 class="display-4">Welcome to EventEase</h1>
    <p class="lead">Your go-to platform for efficient venue and event bookings.</p>
    <p>Manage venues, organize events, and handle bookings—all in one place.</p>
</div>"

Updating the navigation menu:
OpenAI, 2025. ChatGPT [online] Available at: https://chat.openai.com [Accessed 7 Apr. 2025].
(OpenAI, 2025)
"<ul class="navbar-nav flex-grow-1">
    <li class="nav-item">@Html.ActionLink("Home", "Index", "Home", new { area = "" }, new { @class = "nav-link" })</li>
    <li class="nav-item">@Html.ActionLink("Manage Venues", "Index", "Venues", new { area = "" }, new { @class = "nav-link" })</li>
    <li class="nav-item">@Html.ActionLink("Manage Events", "Index", "Events", new { area = "" }, new { @class = "nav-link" })</li>
    <li class="nav-item">@Html.ActionLink("Manage Bookings", "Index", "Bookings", new { area = "" }, new { @class = "nav-link" })</li>
</ul>"

