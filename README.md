E-COMMERCE
 APPLICATION WITH PRODUCT LISTINGS
 AND A SHOPPING CART USING ASP.NET
 MVC AND ENTITY FRAMEWORK.

CAMPANY : CODTECH IT SOLUTIONS

NAME : SABBELLA ALEKHYA

INTERIN ID : CT08DL1177

DOMAIN : .NET WEB DEVELOPMENT

DURATION : 8 WEEKS

MENTOR : NEELA SANTOSH

DESCRIPTION : The shopping cart is a fundamental component of any e-commerce platform, and integrating it into the SAEcommerceApp enhances the user experience by enabling customers to easily select, review, and manage their intended purchases before placing an order. This feature provides an intuitive way for users to add products they like to a virtual cart, review the selected items, remove unwanted products, and proceed to checkout—all within a seamless web interface styled with Bootstrap.

In this implementation, the shopping cart leverages session storage to maintain the user's selections. Session storage is a server-side feature that preserves data across multiple requests during the user’s visit, making it ideal for storing temporary cart information without needing a database or persistent storage. This simplifies the cart implementation while keeping it functional for typical shopping scenarios.

Program.cs modifications: To support session storage, the application’s startup configuration (Program.cs) is updated to add and configure session services. Specifically, the AddDistributedMemoryCache and AddSession methods are called to enable session support. The session is configured with a timeout of 30 minutes, meaning the cart contents will persist for half an hour of inactivity, enhancing usability without burdening server memory indefinitely. The session middleware (UseSession) is added to the request pipeline to make session features accessible within controllers.

CartController: A new controller named CartController orchestrates all cart-related actions. It defines helper methods to read and write the cart contents stored as a list of product IDs in the user’s session. These helpers serialize the list to JSON and store it under a specific session key. The core actions provided include:

Index: Displays the current items in the cart by retrieving products matching the stored IDs.

AddToCart: Adds a product ID to the cart session if it’s not already present and redirects the user back to the home page.

Remove: Removes a product ID from the cart session, allowing users to manage unwanted items.

Checkout: Simulates placing an order by clearing the cart session and showing a confirmation message.

Views: The user interface is built with Bootstrap to provide a responsive and modern look. On the homepage (Views/Home/Index.cshtml), each product displays an “Add to Cart” button. Clicking this button triggers the AddToCart action in the CartController. A prominent cart icon with a link to the cart page allows users to view their selections at any time.

The cart view (Views/Cart/Index.cshtml) lists all products currently added, showing their names and prices in a neatly formatted table. The total cost of items is calculated and displayed at the bottom. Users can remove individual products with a "Remove" button next to each item. The "Checkout" button prompts the user to confirm their purchase; upon confirmation, the cart is cleared, and a success message is shown.

Benefits and Usability: This shopping cart implementation provides users with a straightforward and familiar e-commerce experience. It maintains cart state across pages and sessions without needing complex database integration, which makes it ideal for learning and small-scale projects. The session-based cart is stateless from the database perspective but reliable during the user’s browsing session.

Additionally, the modular design of CartController and clear separation of concerns make it easy to extend this feature. For instance, adding payment gateway integration or persisting carts in a database can be smoothly incorporated in the future without rewriting the entire cart logic.

In conclusion, the shopping cart in SAEcommerceApp is a clean, beginner-friendly solution that covers essential e-commerce functionality. It allows customers to select multiple items, review them, manage their cart, and place orders—all with an engaging and easy-to-use web interface that mimics professional platforms like Flipkart. This feature significantly improves the overall functionality and completeness of the application.



OUTPUT
