INFT3050 Assignment 2

Developer: James Moon

Submission Date: 3/6/2021
Due Date: 4/6/2021 11:59pm

IMPORTANT NOTES:
- This assignment was not completed with full functionality. It will be explained in a moment, but some areas are not functioning due to starting the project late.
- The website has works without errors or warnings, but to make up for lack of functionality, some dummy data has been added to the website to compensate for testing.
	Some commenting has also been left simply to show an attempt has been made to fix issue before submission.
- Friendly URL was implemented successfully to hide file types, but not full functionality (default having no url structure). But it is also utilized for product.aspx
	so product details are caried over.
- Account security is implemented through the fact that when a page is loaded, the only session data stored is UID. To access other user data, it must all be linked 
	through either the sessionID or product details.
- SSL was not implemeted due to lack of time, but basic security through layering (as mentioned in the last point) is implemented.
- It was discovered that Google disables an option to use the email services for VS after a certain time frame. Its important to know the email sending system has full
	functionality, but if for any reason it breaks, its because Google's option for disabling untrusted sources was turned off automatically.

Areas that have full functionality:
- Login
- Register
- Admin Register
- Products Page
- Product
- Account
- Address
- Invoice
- Session
- Transaction
- Master

Areas that have some functionality: 
- ShoppingCart (dummy prices included in .cs)

Areas that have no functionality:
- Order History