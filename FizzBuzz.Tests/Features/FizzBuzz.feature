Feature: FizzBuzz
    
Scenario: Print numbers from 1 to 15 with FizzBuzz rules
    Given I have a FizzBuzz game
    When I print numbers from 1 to 15
    Then I should see the following output:
        | header   |
        | 1        |
        | 2        |
        | Fizz     |
        | 4        |
        | Buzz     |
        | Fizz     |
        | 7        |
        | 8        |
        | Fizz     |
        | Buzz     |
        | 11       |
        | Fizz     |
        | 13       |
        | 14       |
        | FizzBuzz |

Scenario: Print numbers from 1 to 20 with FizzBuzz rules
    Given I have a FizzBuzz game
    When I print numbers from 1 to 20
    Then I should see the following output:
        | header |
        | 1     |
        | 2     |
        | Fizz  |
        | 4     |
        | Buzz  |
        | Fizz  |
        | 7     |
        | 8     |
        | Fizz  |
        | Buzz  |
        | 11    |
        | Fizz  |
        | 13    |
        | 14    |
        | FizzBuzz |
        | 16    |
        | 17    |
        | Fizz  |
        | 19    |
        | Buzz  |
    