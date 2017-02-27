README

Yonjae Lee (yonjlee) - A590 Final Project

RemindMe is my 


Details:

Both forms have maximize box disabled, because they do not need to be maximized.

Integrity check: The AM/PM selection combobox will not accept any manual input;
i.e. users cannot type letters into the combobox using keyboard.

The hour textbox will only accept whole number input ranging from 0 to 23 if the top option 
(lasts for ...) is chosen. When the bottom option (ends at ...) is chosen, that range
is from 1 to 12.

Under both options, both minute and second textboxes will only accept whole number inputs 
ranging from 0 to 59.

No textboxes in groupbox 3 accepts non-numeral input; Error message occurs

tab index: Reminder textbox (txtTimerContent) -> radio buttons -> hour (txtHour) ->
           minute (txtMinute) -> second (txtSecond) -> AM/PM (cboAMPM) -> 
           START button -> Reset button -> Exit button

Countdown end MessageBox is supposed to show up when the remaining time becomes zero.
Countdown never starts if the given duration is zero.

- Object enable/disable:
 - every control in Groupbox 3 (countdown) is disabled until an option in Groupbox 2 is chosen.
  - ComboBox for AM/PM selection is the only control among them enabled only by the 
    bottom option and disabled again by the top option.


Last-minute changes:

- Added a status bar at the bottom of application.
 - Displays current local time based on local time; updates every second
 - Displays developer's name and email

- The countdown form no longer counts the centiseconds. Refreshing the countdown every 10
  milliseconds slowed down the countdown in practice, and I thought the users are not
  likely to care about the last 0.01 seconds.

- Added reset button.

- Now automatic reset is performed before countdown starts; stopping countdown will not
  preserve previous timer settings.

- "Timer is already running" error message has not been implemented. I need to learn more
  about inter-form communications.

- The beeping sound is provided by the MessageBox alert sound.


Program icon courtesy of 
http://www.iconarchive.com/show/flat-finance-icons-by-graphicloads/timer-icon.html
