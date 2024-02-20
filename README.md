# Bus Ticket Sales System Web App

---

## Investigation of Domain:

The bus ticket sales system is a web application designed to facilitate the purchase of bus tickets online. This domain involves managing various aspects such as scheduling, seat availability, payment processing, user authentication, route searching and ticket generation.

## Definition of Main Features:

1. **User Registration and Authentication:**
   - Allow users to register accounts and log in securely using email or phone.
   - Implement SMS-code authentication for user data verification.
   
2. **Search and Booking:**
   - Provide a search interface for users to find available bus routes, dates, and seats.
   - Enable users to select desired seats and book tickets.
   
3. **Seat Selection:**
   - Implement an interactive seat map for users to choose their preferred seats.
   - For double-decker bus provide floor selection.
   
4. **Payment Processing:**
   - Integrate payment gateways for secure transactions using card form or GooglePay/ApplePay.
   
5. **Ticket Generation:**
   - Automatically generate digital tickets upon successful booking.
   - Notifications on successful tickets booking via SMS/Messengers(Viber/WhatsApp) with ticket and bus information
   
6. **User Profile Management:**
   - Allow users to manage their profiles, view booking history, and update personal information.
   - Cancel existing booking and viewing current\future one
     
7. **Support Form:**
   - Generate support token with selected booking.
   - Provide form and list of problem types for addictional isue information.
   
8. **Admin Panel:**
   - Create an admin dashboard for managing bus routes, schedules, seat availability, and user accounts.

## Definition of Main Entities:

1. **User:**
   - Attributes: username, email, password, booking history.
   
2. **Bus Route:**
   - Attributes: origin, destination, departure time, arrival time, bus type.
   
3. **Bus Schedule:**
   - Attributes: date, available seats, price.
   
4. **Booking:**
   - Attributes: user, bus schedule, seats booked, payment status.

# :heavy_exclamation_mark: UNDER DEVELOPMENT
## Main Pages Mockups:

1. **Homepage:**
   - Includes search functionality and featured routes.
   
2. **Search Results Page:**
   - Displays available bus schedules based on user input.
   
3. **Seat Selection Page:**
   - Shows an interactive seat map for users to select seats.
   
4. **Booking Confirmation Page:**
   - Confirms successful booking and provides ticket details.
   
5. **User Profile Page:**
   - Allows users to manage their bookings and update personal information.
   
6. **Admin Dashboard:**
   - Provides access to manage bus routes, schedules, and user accounts.

## Mockup Images:

- [Homepage Mockup](mockups/homepage.png)
- [Search Results Mockup](mockups/search_results.png)
- [Seat Selection Mockup](mockups/seat_selection.png)
- [Booking Confirmation Mockup](mockups/booking_confirmation.png)
- [User Profile Mockup](mockups/user_profile.png)
- [Admin Dashboard Mockup](mockups/admin_dashboard.png)

These mockups provide a visual representation of the main pages and interfaces of the bus ticket sales system web application, helping to guide the initial implementation process.
