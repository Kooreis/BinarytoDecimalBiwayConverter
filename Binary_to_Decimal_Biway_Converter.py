def binary_to_decimal(binary):
    return int(binary, 2)

def decimal_to_binary(decimal):
    return bin(decimal).replace("0b", "")

while True:
    print("1. Binary to Decimal")
    print("2. Decimal to Binary")
    print("3. Exit")
    choice = int(input("Enter your choice: "))
    if choice == 1:
        binary = input("Enter a binary number: ")
        print("Decimal: ", binary_to_decimal(binary))
    elif choice == 2:
        decimal = int(input("Enter a decimal number: "))
        print("Binary: ", decimal_to_binary(decimal))
    elif choice == 3:
        break
    else:
        print("Invalid choice")