inventory = ["shoes, 12, 29.99", "shirts, 20, 9.99", "sweatpants, 25, 15.00", "scarves, 13, 7.75"]

for item in inventory:
    item_data = item.split(",")
    item_name = item_data[0].strip()  # Remove leading/trailing spaces
    stock = item_data[1].strip()
    price = item_data[2].strip()
    print("The store has {} {}, each for {} USD.".format(stock, item_name, price))